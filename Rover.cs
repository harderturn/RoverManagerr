using System;
using System.Collections.Generic;
using System.Text;

namespace RoverManager
{
    class Rover
    {

        public Rover(int startX, int startY, String startDirection, int xLimit, int yLimit)
        {
            _x = startX;
            _y = startY;
            _direction = startDirection;

            _xLimit = xLimit;
            _yLimit = yLimit;
        }

        // Location
        private int _x;
        private int _y;
        private String _direction;

        // Limits
        private int _xLimit;
        private int _yLimit;

        public Rover moveWithCommands(String commandChars) {

            var commandCharArray = commandChars.ToCharArray();

            for (int i = 0; i < commandCharArray.Length; i++)
            {

                switch (commandCharArray[i])
                {
                    case 'L':
                        switch (this._direction)
                        {
                            case "N":
                                this._direction = "W";
                                break;
                            case "S":
                                this._direction = "E";
                                break;
                            case "W":
                                this._direction = "S";
                                break;
                            case "E":
                                this._direction = "N";
                                break;
                            default:
                                break;
                        }


                        break;
                    case 'R':
                        switch (this._direction)
                        {
                            case "N":
                                this._direction = "E";
                                break;
                            case "S":
                                this._direction = "W";
                                break;
                            case "W":
                                this._direction = "N";
                                break;
                            case "E":
                                this._direction = "S";
                                break;
                            default:
                                break;
                        }

                        break;
                    case 'M':

                        switch (this._direction)
                        {
                            case "N":
                                this._y +=1;
                                break;
                            case "S":
                                this._y -= 1;
                                break;
                            case "W":
                                this._x -= 1;
                                break;
                            case "E":
                                this._x += 1;
                                break;
                            default:
                                break;
                        }

                        break;
                    
                    default:
                        Console.WriteLine("Wrong command, rover set to 0 0 N");
                        this._x = 0;
                        this._y = 0;
                        this._direction = "N";
                        break;

                    
                }

                // Limit control.
                if (this._x > _xLimit || this._y > _yLimit)
                {
                    Console.WriteLine("Limits exceeded by rover!");
                    this._x = 0;
                    this._y = 0;
                    this._direction = "N";
                }

            }

            return this;
        }

        public String getRoverPositionInfo() {
            String info = this._x + " " + this._y + " " + this._direction;
            return info;
        }

    }
}
