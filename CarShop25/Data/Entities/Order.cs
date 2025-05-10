namespace CarShop25.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public virtual ICollection<OrderCar>? OrderedCars { get; set; }
    }
}