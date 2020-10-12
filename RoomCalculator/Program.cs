using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double roomLength, roomWidth, roomHeight, roomPerimeter, roomVolume, roomArea;
            char keepGoing = 'y', measureVolume;

            while (keepGoing == 'y') {
                Console.WriteLine("What is the length of the room in meters?");
                roomLength = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What is the width of the room in meters?");
                roomWidth = Convert.ToDouble(Console.ReadLine());

                roomPerimeter = calculateRoomPerimeter(roomLength, roomWidth);
                roomArea = calculateRoomArea(roomLength, roomWidth);

                Console.WriteLine($"The room is {roomLength}m long and {roomWidth}m wide. Great!");
                Console.WriteLine($"That means the perimeter of this room is {roomPerimeter:0.00}m and the area is {roomArea:0.00} Sq m \n");

                Console.WriteLine("Would you like to know the volume of this room? y/n");
                measureVolume = char.Parse(Console.ReadLine());

                if (measureVolume == 'y')
                {
                    Console.WriteLine($"What is the height of this room?");
                    roomHeight = Convert.ToDouble(Console.ReadLine());
                    roomVolume = calculateRoomVolume(roomLength, roomWidth, roomHeight);

                    Console.WriteLine($"The volume of this room is {roomVolume} Cu m \n");
                }
                else {
                    Console.WriteLine("No worries, room volumes are overrated anyway!");
                }

                Console.WriteLine("Should we measure another room? y/n");
                keepGoing = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("That was fun, see you later!");

            double calculateRoomArea(double roomLength, double roomWidth) {
                return roomLength * roomWidth;
            }

            double calculateRoomPerimeter(double roomLength, double roomWidth) {
                return (roomLength * 2) + (roomWidth * 2);
            }

            double calculateRoomVolume(double roomLength, double roomWidth, double roomHeight) {
                return (roomLength * roomWidth) * roomHeight;
            }
        }
    }
}
