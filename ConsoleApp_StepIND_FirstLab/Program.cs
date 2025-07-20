// OOP
//შექმენი Vehicle კლასი, რომელსაც ექნება Speed ველი და Move() მეთოდი.
//შემდეგ შექმენი Car კლასი, რომელიც მემკვიდრეობით მიიღებს Vehicle-ს და
//დაამატე ახალი მეთოდი Honk().
Car car = new Car(100, DateTime.Now);
car.Move();
car.Speed = 100;

class Vehicle // ამის ობიექტი არ უნდა შეიქმნას
{
    private uint _speed;
    public uint Speed { get; set; }

    public Vehicle(uint speed)
    {
        this.Speed = speed;
    }

    public void Move()
    {

    }
}

class Car : Vehicle
{
    public DateTime ReleaseDate { get; set; }

    public Car(uint speed, DateTime releaseDate) : 
        base(speed)
    {
        //_speed = 0; ineccassible
        this.ReleaseDate = releaseDate;
    }
}
