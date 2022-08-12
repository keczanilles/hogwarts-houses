using System.Collections.Generic;
using HogwartsHouses.Models;

namespace HogwartsHouses.DAL
{
    public interface IRepository<T>
    {
        public void AddRoom(Room room);


        public void AddStudentToRoom(int roomId, string name);


        public void AddStudent(Student student);


        public HashSet<Room> GetRooms();


        public HashSet<Student> GetStudents();


        public Room GetRoom(int id);


        public void DeleteRoom(int id);


        public void UpdateRoom(int id);


        public HashSet<Room> GetAvailableRooms();


        public HashSet<Room> GetStudentsWithOnlyRats();
    }
}
