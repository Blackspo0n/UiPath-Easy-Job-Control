using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using UiPathEJC.Annotations;

namespace UiPathEJC.UserInterfaces.Base
{
    //  https://stackoverflow.com/questions/30740642/asynchronous-mvvm-commands
    public class AsyncCommand<TResult> : AsyncCommandBase, INotifyPropertyChanged
    {
        private readonly CancelAsyncCommand _cancelCommand;
        private readonly Func<object, CancellationToken, Task<TResult>> _command;
        private NotifyTaskCompletion<TResult> _execution;


        public AsyncCommand(Func<object, CancellationToken, Task<TResult>> command)
        {
            _command = command;
            _cancelCommand = new CancelAsyncCommand();
        }

        public ICommand CancelCommand => _cancelCommand;

        public NotifyTaskCompletion<TResult> Execution
        {
            get => _execution;
            private set
            {
                _execution = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public override bool CanExecute(object parameter)
        {
            return (Execution == null || Execution.IsCompleted);
        }

        public override async Task ExecuteAsync([CanBeNull] object parameter)
        {
            _cancelCommand.NotifyCommandStarting();
            Execution = new NotifyTaskCompletion<TResult>(_command(parameter, _cancelCommand.Token));
            RaiseCanExecuteChanged();

            if (Execution?.TaskCompletion != null) await Execution?.TaskCompletion;
            _cancelCommand.NotifyCommandFinished();
            RaiseCanExecuteChanged();
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private sealed class CancelAsyncCommand : ICommand
        {
            private bool _commandExecuting;
            private CancellationTokenSource _cts = new CancellationTokenSource();

            public CancellationToken Token => _cts.Token;

            bool ICommand.CanExecute(object parameter)
            {
                return _commandExecuting && !_cts.IsCancellationRequested;
            }

            void ICommand.Execute(object parameter)
            {
                _cts.Cancel();
                RaiseCanExecuteChanged();
            }

            public event EventHandler CanExecuteChanged
            {
                add => CommandManager.RequerySuggested += value;
                remove => CommandManager.RequerySuggested -= value;
            }

            public void NotifyCommandStarting()
            {
                _commandExecuting = true;
                if (!_cts.IsCancellationRequested)
                    return;
                _cts = new CancellationTokenSource();
                RaiseCanExecuteChanged();
            }

            public void NotifyCommandFinished()
            {
                _commandExecuting = false;
                RaiseCanExecuteChanged();
            }

            private void RaiseCanExecuteChanged()
            {
                CommandManager.InvalidateRequerySuggested();
            }
        }
    }
    public static class AsyncCommandEx
    {
        public static AsyncCommand<object> Create(Func<Task> command)
        {
            return new AsyncCommand<object>(async (param, _) =>
            {
                await command();
                return null;
            });
        }

        public static AsyncCommand<object> Create(Func<object, Task> command)
        {
            return new AsyncCommand<object>(async (param, _) =>
            {
                await command(param);
                return null;
            });
        }

        public static AsyncCommand<TResult> Create<TResult>(Func<Task<TResult>> command)
        {
            return new AsyncCommand<TResult>((param, _) => command());
        }

        public static AsyncCommand<TResult> Create<TResult>(Func<object, Task<TResult>> command)
        {
            return new AsyncCommand<TResult>((param, _) => command(param));
        }

        public static AsyncCommand<object> Create(Func<CancellationToken, Task> command)
        {
            return new AsyncCommand<object>(async (param, token) =>
            {
                await command(token);
                return null;
            });
        }

        public static AsyncCommand<object> Create(Func<object, CancellationToken, Task> command)
        {
            return new AsyncCommand<object>(async (param, token) =>
            {
                await command(param, token);
                return null;
            });
        }

        public static AsyncCommand<TResult> Create<TResult>(Func<CancellationToken, Task<TResult>> command)
        {
            return new AsyncCommand<TResult>(async (param, token) => await command(token));
        }

        public static AsyncCommand<TResult> Create<TResult>(Func<object, CancellationToken, Task<TResult>> command)
        {
            return new AsyncCommand<TResult>(async (param, token) => await command(param, token));
        }
    }
    public class AsyncCommand : AsyncCommandBase
    {
        private readonly Func<Task> _command;
        public AsyncCommand(Func<Task> command)
        {
            _command = command;
        }
        public override bool CanExecute(object parameter)
        {
            return true;
        }
        public override Task ExecuteAsync(object parameter)
        {
            return _command();
        }
    }
}