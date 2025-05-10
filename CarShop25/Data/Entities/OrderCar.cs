namespace CarShop25.Data.Entities
{
    public class OrderCar
    {
        public int OrderId { get; set; }
        public virtual Order? Order { get; set; }
        public int CarId { get; set; }
        public virtual Car? Car{ get; set; }
        public double Quantity { get; set; }
    }
}