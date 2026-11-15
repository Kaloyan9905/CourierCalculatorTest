namespace CourierCalculatorTest;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void buttonAcceptOrder_Click(object sender, EventArgs e)
    {
        // Kaloyan Ivelinov Milchev; F118428 - NBU
        
        // check if name is not empty input
        if (string.IsNullOrWhiteSpace(textBoxRecipient.Text))
        {
            MessageBox.Show("Името не може да бъде празно!");
            return;
        }

        // check if weight is correct and we can parse its value; weight cannot be negative number
        bool isValidWeight = double.TryParse(textBoxPackageTotalWeight.Text, out double weight);
        if (!isValidWeight || weight <= 0)
        {
            MessageBox.Show("Теглото трябва да е валидно число!");
            return;
        }

        // check if distance is correct and we can parse its value; distance cannot be negative number;
        bool isValidDistance = double.TryParse(textBoxDeliveryDistance.Text, out double distance);
        if (!isValidDistance || distance <= 0)
        {
            MessageBox.Show("Разстоянието трябва да е валидно число!");
        }

        decimal deliveryType;
        if (radioButtonEconomy.Checked)
        {
            deliveryType = 4m;
        }
        else if (radioButtonStandart.Checked)
        {
            deliveryType = 6m;
        }
        else // Express
        {
            deliveryType = 10m;
        }

        Shipment newShipment = new Shipment(
            textBoxRecipient.Text,
            distance,
            weight,
            deliveryType,
            checkBoxFragileContent.Checked,
            checkBoxDeliveryToAddress.Checked);

        string text =
            $"Пратка за {newShipment.Recipient} - Цена: {newShipment.CalculateTotalPrice():F2} лв. и Тегло - {newShipment.Weight} кг.";
        listBoxOrdersInformation.Items.Add(text);

        labelAverageOrderWeight.Text = $"Средно тегло на пратка: {Shipment.CalculateAverageWeight():F2}";
        labelTotalRevenue.Text = $"Общ оборот от всички пратки: {Shipment.CalculateTotalPriceForAllShipments():F2}";

        textBoxRecipient.Clear();
        textBoxPackageTotalWeight.Clear();
        textBoxDeliveryDistance.Clear();
        radioButtonEconomy.Checked = true;
        checkBoxDeliveryToAddress.Checked = false;
        checkBoxFragileContent.Checked = false;
    }
}