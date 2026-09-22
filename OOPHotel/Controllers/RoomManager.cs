//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace OOPHotel.Controllers
//{
//    internal class RoomManager
//    {
//        public class RoomManager
//        {
//            private Room[] rooms;
//            private List<Booking> bookings;

//            public RoomManager(Room[] rooms)
//            {
//                this.rooms = rooms;
//                bookings = new List<Booking>();
//            }

//            public bool IsRoomAvailable(int roomNumber, DateTime checkIn, DateTime checkOut)
//            {
//<<<<<<< HEAD

//                foreach (Booking booking in bookings)
//                {
//                    bool sameRoom = booking.RoomNumber == roomNumber;

//                    bool datesOverlap = checkIn < booking.CheckOut && checkOut > booking.CheckIn;

//                    if (sameRoom && datesOverlap)
//                    {
//                        return false;
//                    }
//                }

//                return true;
//            }

//            public bool BookRoom(int roomNumber, DateTime checkIn, DateTime checkOut)
//            {
//                if (checkOut <= checkIn)
//=======
//                foreach (Booking booking in bookings)
//                {
//                    bool sameRoom = booking.RoomNumber == roomNumber;

//                    bool datesOverlap = checkIn < booking.CheckOut && checkOut > booking.CheckIn;

//                    if (sameRoom && datesOverlap)
//                    {
//                        return false;
//                    }
//                }

//                return true;
//            }

//            public bool BookRoom(int roomNumber,DateTime checkIn,DateTime checkOut)
//            {
//                if (checkOut <= checkIn)
//                {
//                    return false;
//                }

//                if (!RoomExists(roomNumber))
//>>>>>>> 8411b33f6c0b364dbdb34eca541535c11d9d8d0f
//                {
//                    return false;
//                }

//<<<<<<< HEAD
//                if (!RoomExists(roomNumber))
//=======
//                if (!IsRoomAvailable(roomNumber,checkIn,checkOut))
//>>>>>>> 8411b33f6c0b364dbdb34eca541535c11d9d8d0f
//                {
//                    return false;
//                }

//<<<<<<< HEAD
//                if (!IsRoomAvailable(roomNumber, checkIn, checkOut))
//                {
//                    return false;
//                }

//                Booking newBooking = new Booking(roomNumber, checkIn, checkOut);

//                bookings.Add(newBooking);

//                return true;
//            }

//            public Room[] GetAvailableRooms(DateTime checkIn, DateTime checkOut)
//            {
//                List<Room> availableRooms = new List<Room>();

//                foreach (Room room in rooms)
//                {
//                    if (IsRoomAvailable(room.RoomNumber, checkIn, checkOut))
//                    {
//                        availableRooms.Add(room);
//                    }
//                }

//                return availableRooms.ToArray();
//            }

//            private bool RoomExists(int roomNumber)
//            {
//                foreach (Room room in rooms)
//                {
//                    if (room.RoomNumber == roomNumber)
//                    {
//                        return true;
//                    }
//                }

//=======
//                Booking newBooking = new Booking(roomNumber,checkIn,checkOut);

//                bookings.Add(newBooking);

//                return true;
//            }

//            public Room[] GetAvailableRooms(DateTime checkIn,DateTime checkOut)
//            {
//                List<Room> availableRooms = new List<Room>();

//                foreach (Room room in rooms)
//                {
//                    if (IsRoomAvailable(room.RoomNumber,checkIn,checkOut))
//                    {
//                        availableRooms.Add(room);
//                    }
//                }

//                return availableRooms.ToArray();
//            }

//            private bool RoomExists(int roomNumber)
//            {
//                foreach (Room room in rooms)
//                {
//                    if (room.RoomNumber == roomNumber)
//                    {
//                        return true;
//                    }
//                }

//>>>>>>> 8411b33f6c0b364dbdb34eca541535c11d9d8d0f
//                return false;
//            }
//        }
//    }
//}
