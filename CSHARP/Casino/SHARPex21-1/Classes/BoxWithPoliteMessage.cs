using System;

namespace SHARPex21_1.Classes
{
    class BoxWithPoliteMessage: EventArgs
    {
        public string Message { get; private set; }

        public static BoxWithPoliteMessage Pack(string message) => new BoxWithPoliteMessage() { Message = message };
    }
}
