using System;
namespace ChristmasWithTypes
{
    public class Christmas
    {
        public string[] Presents;
        public string Santa { get; set; }
        public int? TreeHeight { get; set; } //TODO Make the Height property nullable

        //TODO Make the property, "Day", type enum
        public enum Day { Monday, Tuesday, Wenseday, Thursday, Friday, Saturday };

    }
    // vlaue types are stored in a stack
    //value types are the actual value
    //Ctrl and clicking value type shows you the value 
    //highlight code  press ALt and down arrow moves your code.
}
