namespace CourierCalculatorTest;

public class Shipment
{
    public string Recipient { get; private set; }
    public double Distance { get; private set; }
    public double Weight { get; private set; }
    private decimal PricePerFeature { get; set; }
    public bool IsFragile { get; set; }
    public bool IsForDeliveryToAddress { get; set; }

    public static List<Shipment> Shipments { get; private set; } = new();

    public Shipment(string recipient, double distance, double weight, decimal pricePerFeature, bool isFragile,
        bool isForDeliveryToAddress)
    {
        Recipient = recipient;
        Distance = distance;
        Weight = weight;
        PricePerFeature = pricePerFeature;
        IsFragile = isFragile;
        IsForDeliveryToAddress = isForDeliveryToAddress;
        Shipments.Add(this);
    }

    public decimal CalculateTotalPrice()
    {
        // we make sure to include the price from the checkBox for diff kind of delivery
        decimal total = PricePerFeature;
        total += (decimal)Weight * 1.2m;
        total += (decimal)Distance * 0.05m;

        if (IsForDeliveryToAddress)
        {
            total += 5m;
        }

        if (IsFragile)
        {
            total += total * 0.30m;
        }

        return total;
    }

    public static decimal CalculateTotalPriceForAllShipments()
    {
        decimal total = 0m;
        foreach (Shipment shipment in Shipments)
        {
            total += shipment.CalculateTotalPrice();
        }

        return total;
    }

    public static double CalculateAverageWeight()
    {
        if (Shipments.Count == 0)
        {
            return 0;
        }

        double total = 0;
        foreach (Shipment shipment in Shipments)
        {
            total += shipment.Weight;
        }

        return total / Shipments.Count;
    }
}