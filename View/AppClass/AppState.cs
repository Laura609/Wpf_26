using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows;

namespace Wpf_26.View.AppClass
{
    [Serializable]
    public class AppState
    {
        public string Property1 { get; set; }
        public int Property2 { get; set; }
        // Добавьте другие свойства, которые вы хотите сохранить

        public static class AppStateManager
        {
            private static readonly string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appState.bin");

            public static void SaveState(AppState state)
            {
                using (var stream = File.OpenWrite(FilePath))
                {
                    var serializer = new BinaryFormatter();
                    serializer.Serialize(stream, state);
                }
            }

            public static AppState LoadState()
            {
                if (File.Exists(FilePath))
                {
                    using (var stream = File.OpenRead(FilePath))
                    {
                        var serializer = new BinaryFormatter();
                        return (AppState)serializer.Deserialize(stream);
                    }
                }

                return new AppState();
            }
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var state = AppStateManager.LoadState();

            // Используйте свойства state для восстановления состояния вашего приложения
        }
        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);

            var state = new AppState
            {
                Property1 = "value1",
                Property2 = 42
                // Заполните свойства state текущим состоянием вашего приложения
            };
        AppStateManager.SaveState(state);
        }
    }
}

