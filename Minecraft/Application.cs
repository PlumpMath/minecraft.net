using System.Collections.Generic;

using OpenTK;

using Minecraft.Window;
using Minecraft.States;

namespace Minecraft {
    class Application {
        private Stack<GameState> states;

        public Display Display { get; private set; }

        public Application(Display display) {
            Display = display;

            display.OnFrameRender += DisplayOnFrameRender;

            states = new Stack<GameState>();
        }

        private void DisplayOnFrameRender(object sender, FrameEventArgs e) {
            var state = states.Peek();

            state.Draw();
        }

        public void PushState(GameState state) {
            states.Push(state);
        }

        public void PopState() {
            states.Pop();
        }

        public void Run() {
            Display.Run();
        }
    }
}
