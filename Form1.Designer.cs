namespace CourierCalculatorTest;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        textBoxRecipient = new System.Windows.Forms.TextBox();
        labelRecipient = new System.Windows.Forms.Label();
        labelPackageTotalWeight = new System.Windows.Forms.Label();
        textBoxPackageTotalWeight = new System.Windows.Forms.TextBox();
        labelDeliveryDistance = new System.Windows.Forms.Label();
        textBoxDeliveryDistance = new System.Windows.Forms.TextBox();
        groupBoxFeatureType = new System.Windows.Forms.GroupBox();
        radioButtonExpress = new System.Windows.Forms.RadioButton();
        radioButtonStandart = new System.Windows.Forms.RadioButton();
        radioButtonEconomy = new System.Windows.Forms.RadioButton();
        groupBoxFeatures = new System.Windows.Forms.GroupBox();
        checkBoxDeliveryToAddress = new System.Windows.Forms.CheckBox();
        checkBoxFragileContent = new System.Windows.Forms.CheckBox();
        buttonAcceptOrder = new System.Windows.Forms.Button();
        listBoxOrdersInformation = new System.Windows.Forms.ListBox();
        labelTotalRevenue = new System.Windows.Forms.Label();
        labelAverageOrderWeight = new System.Windows.Forms.Label();
        groupBoxFeatureType.SuspendLayout();
        groupBoxFeatures.SuspendLayout();
        SuspendLayout();
        // 
        // textBoxRecipient
        // 
        textBoxRecipient.Location = new System.Drawing.Point(53, 62);
        textBoxRecipient.Name = "textBoxRecipient";
        textBoxRecipient.Size = new System.Drawing.Size(106, 31);
        textBoxRecipient.TabIndex = 0;
        // 
        // labelRecipient
        // 
        labelRecipient.Location = new System.Drawing.Point(53, 29);
        labelRecipient.Name = "labelRecipient";
        labelRecipient.Size = new System.Drawing.Size(106, 30);
        labelRecipient.TabIndex = 1;
        labelRecipient.Text = "Получател";
        // 
        // labelPackageTotalWeight
        // 
        labelPackageTotalWeight.Location = new System.Drawing.Point(195, 29);
        labelPackageTotalWeight.Name = "labelPackageTotalWeight";
        labelPackageTotalWeight.Size = new System.Drawing.Size(203, 30);
        labelPackageTotalWeight.TabIndex = 3;
        labelPackageTotalWeight.Text = "тегло на пратката (в кг)";
        // 
        // textBoxPackageTotalWeight
        // 
        textBoxPackageTotalWeight.Location = new System.Drawing.Point(195, 62);
        textBoxPackageTotalWeight.Name = "textBoxPackageTotalWeight";
        textBoxPackageTotalWeight.Size = new System.Drawing.Size(203, 31);
        textBoxPackageTotalWeight.TabIndex = 2;
        // 
        // labelDeliveryDistance
        // 
        labelDeliveryDistance.Location = new System.Drawing.Point(432, 29);
        labelDeliveryDistance.Name = "labelDeliveryDistance";
        labelDeliveryDistance.Size = new System.Drawing.Size(260, 30);
        labelDeliveryDistance.TabIndex = 5;
        labelDeliveryDistance.Text = "разстояние за доставка (в км)";
        // 
        // textBoxDeliveryDistance
        // 
        textBoxDeliveryDistance.Location = new System.Drawing.Point(432, 62);
        textBoxDeliveryDistance.Name = "textBoxDeliveryDistance";
        textBoxDeliveryDistance.Size = new System.Drawing.Size(260, 31);
        textBoxDeliveryDistance.TabIndex = 4;
        // 
        // groupBoxFeatureType
        // 
        groupBoxFeatureType.Controls.Add(radioButtonExpress);
        groupBoxFeatureType.Controls.Add(radioButtonStandart);
        groupBoxFeatureType.Controls.Add(radioButtonEconomy);
        groupBoxFeatureType.Location = new System.Drawing.Point(53, 122);
        groupBoxFeatureType.Name = "groupBoxFeatureType";
        groupBoxFeatureType.Size = new System.Drawing.Size(344, 150);
        groupBoxFeatureType.TabIndex = 6;
        groupBoxFeatureType.TabStop = false;
        groupBoxFeatureType.Text = "Тип услуга";
        // 
        // radioButtonExpress
        // 
        radioButtonExpress.Location = new System.Drawing.Point(16, 106);
        radioButtonExpress.Name = "radioButtonExpress";
        radioButtonExpress.Size = new System.Drawing.Size(310, 30);
        radioButtonExpress.TabIndex = 2;
        radioButtonExpress.Text = " Експресна (10.00 лв.)";
        radioButtonExpress.UseVisualStyleBackColor = true;
        // 
        // radioButtonStandart
        // 
        radioButtonStandart.Location = new System.Drawing.Point(16, 70);
        radioButtonStandart.Name = "radioButtonStandart";
        radioButtonStandart.Size = new System.Drawing.Size(310, 30);
        radioButtonStandart.TabIndex = 1;
        radioButtonStandart.Text = "Стандартна (6.00 лв.)";
        radioButtonStandart.UseVisualStyleBackColor = true;
        // 
        // radioButtonEconomy
        // 
        radioButtonEconomy.Checked = true;
        radioButtonEconomy.Location = new System.Drawing.Point(16, 34);
        radioButtonEconomy.Name = "radioButtonEconomy";
        radioButtonEconomy.Size = new System.Drawing.Size(310, 30);
        radioButtonEconomy.TabIndex = 0;
        radioButtonEconomy.TabStop = true;
        radioButtonEconomy.Text = "Икономична (базова цена 4.00 лв.)";
        radioButtonEconomy.UseVisualStyleBackColor = true;
        // 
        // groupBoxFeatures
        // 
        groupBoxFeatures.Controls.Add(checkBoxDeliveryToAddress);
        groupBoxFeatures.Controls.Add(checkBoxFragileContent);
        groupBoxFeatures.Location = new System.Drawing.Point(432, 122);
        groupBoxFeatures.Name = "groupBoxFeatures";
        groupBoxFeatures.Size = new System.Drawing.Size(324, 149);
        groupBoxFeatures.TabIndex = 7;
        groupBoxFeatures.TabStop = false;
        groupBoxFeatures.Text = "Особености";
        // 
        // checkBoxDeliveryToAddress
        // 
        checkBoxDeliveryToAddress.Location = new System.Drawing.Point(12, 71);
        checkBoxDeliveryToAddress.Name = "checkBoxDeliveryToAddress";
        checkBoxDeliveryToAddress.Size = new System.Drawing.Size(283, 29);
        checkBoxDeliveryToAddress.TabIndex = 1;
        checkBoxDeliveryToAddress.Text = "Доставка до адрес (+5.00 лв.)";
        checkBoxDeliveryToAddress.UseVisualStyleBackColor = true;
        // 
        // checkBoxFragileContent
        // 
        checkBoxFragileContent.Location = new System.Drawing.Point(12, 34);
        checkBoxFragileContent.Name = "checkBoxFragileContent";
        checkBoxFragileContent.Size = new System.Drawing.Size(283, 29);
        checkBoxFragileContent.TabIndex = 0;
        checkBoxFragileContent.Text = "Чупливо съдържание (+30%)";
        checkBoxFragileContent.UseVisualStyleBackColor = true;
        // 
        // buttonAcceptOrder
        // 
        buttonAcceptOrder.Location = new System.Drawing.Point(53, 288);
        buttonAcceptOrder.Name = "buttonAcceptOrder";
        buttonAcceptOrder.Size = new System.Drawing.Size(703, 46);
        buttonAcceptOrder.TabIndex = 8;
        buttonAcceptOrder.Text = "Приеми пратката";
        buttonAcceptOrder.UseVisualStyleBackColor = true;
        buttonAcceptOrder.Click += buttonAcceptOrder_Click;
        // 
        // listBoxOrdersInformation
        // 
        listBoxOrdersInformation.FormattingEnabled = true;
        listBoxOrdersInformation.Location = new System.Drawing.Point(54, 358);
        listBoxOrdersInformation.Name = "listBoxOrdersInformation";
        listBoxOrdersInformation.Size = new System.Drawing.Size(701, 329);
        listBoxOrdersInformation.TabIndex = 9;
        // 
        // labelTotalRevenue
        // 
        labelTotalRevenue.Location = new System.Drawing.Point(54, 713);
        labelTotalRevenue.Name = "labelTotalRevenue";
        labelTotalRevenue.Size = new System.Drawing.Size(344, 42);
        labelTotalRevenue.TabIndex = 10;
        labelTotalRevenue.Text = "Общ оборот от всички пратки";
        // 
        // labelAverageOrderWeight
        // 
        labelAverageOrderWeight.Location = new System.Drawing.Point(444, 713);
        labelAverageOrderWeight.Name = "labelAverageOrderWeight";
        labelAverageOrderWeight.Size = new System.Drawing.Size(311, 42);
        labelAverageOrderWeight.TabIndex = 11;
        labelAverageOrderWeight.Text = "Средно тегло на пратка";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 886);
        Controls.Add(labelAverageOrderWeight);
        Controls.Add(labelTotalRevenue);
        Controls.Add(listBoxOrdersInformation);
        Controls.Add(buttonAcceptOrder);
        Controls.Add(groupBoxFeatures);
        Controls.Add(groupBoxFeatureType);
        Controls.Add(labelDeliveryDistance);
        Controls.Add(textBoxDeliveryDistance);
        Controls.Add(labelPackageTotalWeight);
        Controls.Add(textBoxPackageTotalWeight);
        Controls.Add(labelRecipient);
        Controls.Add(textBoxRecipient);
        Text = "Калоян Ивелинов Милчев F118428";
        groupBoxFeatureType.ResumeLayout(false);
        groupBoxFeatures.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label labelTotalRevenue;
    private System.Windows.Forms.Label labelAverageOrderWeight;

    private System.Windows.Forms.ListBox listBoxOrdersInformation;

    private System.Windows.Forms.Button buttonAcceptOrder;

    private System.Windows.Forms.CheckBox checkBoxFragileContent;
    private System.Windows.Forms.CheckBox checkBoxDeliveryToAddress;

    private System.Windows.Forms.GroupBox groupBoxFeatures;

    private System.Windows.Forms.GroupBox groupBoxFeatureType;
    private System.Windows.Forms.RadioButton radioButtonStandart;
    private System.Windows.Forms.RadioButton radioButtonExpress;

    private System.Windows.Forms.RadioButton radioButtonEconomy;

    private System.Windows.Forms.Label labelPackageTotalWeight;
    private System.Windows.Forms.TextBox textBoxPackageTotalWeight;
    private System.Windows.Forms.Label labelDeliveryDistance;
    private System.Windows.Forms.TextBox textBoxDeliveryDistance;

    private System.Windows.Forms.Label labelRecipient;

    private System.Windows.Forms.TextBox textBoxRecipient;

    #endregion
}