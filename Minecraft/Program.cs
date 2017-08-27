using System;

using Minecraft.States;
using Minecraft.Window;

namespace Minecraft {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            var display = new Display();
            var app = new Application(display);

            var state = new PlayingState(app);

            app.PushState(state);

            app.Run();
        }
    }
}
