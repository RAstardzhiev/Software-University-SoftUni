namespace _08.Pet_Clinics.Models
{
    using System;
    using System.Linq;
    using System.Text;

    public class Clinic : IComparable<Clinic>
    {
        private readonly int firstRoomIndex;

        private string name;
        private Pet[] roomsContent;

        public Clinic(string name, int roomsCount)
        {
            this.Name = name;
            this.ValidateNumberOfRooms(roomsCount);
            this.roomsContent = new Pet[roomsCount];
            this.firstRoomIndex = this.roomsContent.Length / 2;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                this.name = value;
            }
        }

        public int CompareTo(Clinic other)
        {
            return this.name.CompareTo(other.name);
        }

        internal bool AddPet(Pet petToAdd)
        {
            for (int i = 0; i <= this.firstRoomIndex; i++)
            {
                if (this.roomsContent[this.firstRoomIndex - i] == null)
                {
                    this.roomsContent[this.firstRoomIndex - i] = petToAdd;
                    return true;
                }

                if (this.roomsContent[this.firstRoomIndex + i] == null)
                {
                    this.roomsContent[this.firstRoomIndex + i] = petToAdd;
                    return true;
                }
            }

            return false;
        }

        internal bool ReleaseAnimal()
        {
            for (int i = this.firstRoomIndex; i < this.roomsContent.Length; i++)
            {
                if (this.roomsContent[i] != null)
                {
                    this.roomsContent[i] = null;
                    return true;
                }
            }

            for (int i = 0; i < this.firstRoomIndex; i++)
            {
                if (this.roomsContent[i] != null)
                {
                    this.roomsContent = null;
                    return true;
                }
            }

            return false;
        }

        internal bool HasEmptyRooms() => this.roomsContent.Any(r => r == null);

        internal string GetRoomState(int roomNumber)
        {
            roomNumber--;

            if (roomNumber < 0 || roomNumber >= this.roomsContent.Length)
            {
                throw new ArgumentException("Invalid Operation!");
            }

            return (this.roomsContent[roomNumber] == null)
                ? "Room empty"
                : this.roomsContent[roomNumber].ToString();
        }

        internal string GetAllRomsState()
        {
            var sb = new StringBuilder();

            foreach (var room in this.roomsContent)
            {
                if (room == null)
                {
                    sb.AppendLine("Room empty");
                }
                else
                {
                    sb.AppendLine(room.ToString());
                }
            }

            return sb.ToString().Trim();
        }

        private void ValidateNumberOfRooms(int roomsCount)
        {
            if (roomsCount % 2 == 0 || roomsCount < 1 || roomsCount > 101)
            {
                throw new ArgumentException("Invalid Operation!");
            }
        }
    }
}
