using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karbro
{
    public partial class CashOutForm : Form
    {

        public CashOutForm()
        {
            InitializeComponent();
            BMW bmw = new BMW();           
            Volvo volvo = new Volvo();
            Ferrari ferrari = new Ferrari();
            Jaguar jaguar = new Jaguar();
            Ford ford = new Ford();
            Lamborghini lamborghini = new Lamborghini();
            Audi audi = new Audi();
            Honda honda = new Honda();
            Porsche porsche = new Porsche();
            Dodge dodge = new Dodge();
            switch (CarBrands.carbrand)
            {
                case "BMW":                 
                        cashprice = Convert.ToDouble(bmw.price[bmwForm.counter]);
                        oneyearprice = Convert.ToDouble((bmw.price[bmwForm.counter] * .08 * 1) + bmw.price[bmwForm.counter]);
                        twoyearprice = Convert.ToDouble((bmw.price[bmwForm.counter] * .08 * 2) + bmw.price[bmwForm.counter]);
                    break;
                    
                case "Ferrari":                   
                        cashprice = Convert.ToDouble(ferrari.price[ferrariForm.counter]);
                        oneyearprice = Convert.ToDouble((ferrari.price[ferrariForm.counter] * .08 * 1) + ferrari.price[ferrariForm.counter]);
                        twoyearprice = Convert.ToDouble((ferrari.price[ferrariForm.counter] * .08 * 2) + ferrari.price[ferrariForm.counter]);                   
                    break;

                case "Volvo":
                    cashprice = Convert.ToDouble(volvo.price[volvoForm.counter]);
                    oneyearprice = Convert.ToDouble((volvo.price[volvoForm.counter] * .08 * 1) + volvo.price[volvoForm.counter]);
                    twoyearprice = Convert.ToDouble((volvo.price[volvoForm.counter] * .08 * 2) + volvo.price[volvoForm.counter]);
                    break;

                case "Jaguar":
                    cashprice = Convert.ToDouble(jaguar.price[jaguarForm.counter]);
                    oneyearprice = Convert.ToDouble((jaguar.price[jaguarForm.counter] * .08 * 1) + jaguar.price[jaguarForm.counter]);
                    twoyearprice = Convert.ToDouble((jaguar.price[jaguarForm.counter] * .08 * 2) + jaguar.price[jaguarForm.counter]);
                    break;

                case "Ford":
                    cashprice = Convert.ToDouble(ford.price[fordForm.counter]);
                    oneyearprice = Convert.ToDouble((ford.price[fordForm.counter] * .08 * 1) + ford.price[fordForm.counter]);
                    twoyearprice = Convert.ToDouble((ford.price[fordForm.counter] * .08 * 2) + ford.price[fordForm.counter]);
                    break;
                case "Lamborghini":
                    cashprice = Convert.ToDouble(lamborghini.price[lamborghiniForm.counter]);
                    oneyearprice = Convert.ToDouble((lamborghini.price[lamborghiniForm.counter] * .08 * 1) + lamborghini.price[lamborghiniForm.counter]);
                    twoyearprice = Convert.ToDouble((lamborghini.price[lamborghiniForm.counter] * .08 * 2) + lamborghini.price[lamborghiniForm.counter]);
                    break;
                case "Audi":
                    cashprice = Convert.ToDouble(audi.price[audiForm.counter]);
                    oneyearprice = Convert.ToDouble((audi.price[audiForm.counter] * .08 * 1) + audi.price[audiForm.counter]);
                    twoyearprice = Convert.ToDouble((audi.price[audiForm.counter] * .08 * 2) + audi.price[audiForm.counter]);
                    break;
                case "Honda":
                    cashprice = Convert.ToDouble(honda.price[hondaForm.counter]);
                    oneyearprice = Convert.ToDouble((honda.price[hondaForm.counter] * .08 * 1) + honda.price[hondaForm.counter]);
                    twoyearprice = Convert.ToDouble((honda.price[hondaForm.counter] * .08 * 2) + honda.price[hondaForm.counter]);
                    break;
                case "Porsche":
                    cashprice = Convert.ToDouble(porsche.price[porscheForm.counter]);
                    oneyearprice = Convert.ToDouble((porsche.price[porscheForm.counter] * .08 * 1) + porsche.price[porscheForm.counter]);
                    twoyearprice = Convert.ToDouble((porsche.price[porscheForm.counter] * .08 * 2) + porsche.price[porscheForm.counter]);
                    break;
                case "Dodge":
                    cashprice = Convert.ToDouble(dodge.price[dodgeForm.counter]);
                    oneyearprice = Convert.ToDouble((dodge.price[dodgeForm.counter] * .08 * 1) + dodge.price[dodgeForm.counter]);
                    twoyearprice = Convert.ToDouble((dodge.price[dodgeForm.counter] * .08 * 2) + dodge.price[dodgeForm.counter]);
                    break;
            }
        }

        private void CashOutForm_Load(object sender, EventArgs e)
        {

            //accounts
            Accounts.AccountDetails account = new Accounts.AccountDetails();
            int accountcounter = LogInForm.customer;
            shipToLbl.Text = account.lastName[accountcounter] + ", " + account.firstName[accountcounter];
            shipAddressLbl.Text = account.address[accountcounter];
            ContactNoLbl.Text = account.contactNo[accountcounter];
            name = shipToLbl.Text;
            switch(CarBrands.carbrand)
            {
                case "BMW":
                    BMW bmwClass = new BMW();
                    int carspec = bmwForm.counter;
                    string[] modelname = bmwClass.model;
                    string[] enginespecs = bmwClass.engine;
                    string[] enginetypespec = bmwClass.enginetype;
                    string[] horsepowerspec = bmwClass.horsepower;
                    string[] transmissionspec = bmwClass.transimission;
                    string[] maxspeedspec = bmwClass.maxspeed;
                    int[] price = bmwClass.price;
                    CarNameLbl.Text = modelname[carspec];
                    carname = CarNameLbl.Text;
                    engineSpecLbl.Text = enginespecs[carspec];
                    engineTypeSpecLbl.Text = enginetypespec[carspec];
                    horsepowerSpecLbl.Text = horsepowerspec[carspec];
                    transmissionSpecLbl.Text = transmissionspec[carspec];
                    maxSpeedSpecLbl.Text = maxspeedspec[carspec];
                    if (bmwForm.model == "BMW X7")
                    {
                        CarPicBox.Image = Image.FromFile("F:\\Brands\\BMWX72019.jpg");
                    }
                    if (bmwForm.model == "BMW Z4")
                    {
                        CarPicBox.Image = Image.FromFile("F:\\Brands\\BMWZ42019.jpg");
                    }
                    if (bmwForm.model == "BMW GT")
                    {
                        CarPicBox.Image = Image.FromFile("F:\\Brands\\BMWGT2019.jpg");
                    }
                    if (bmwForm.model == "BMW 5 Series")
                    {
                        CarPicBox.Image = Image.FromFile("F:\\Brands\\BMW5Series.jpg");
                    }
                    if (bmwForm.model == "BMW 4 Series Coupe")
                    {
                        CarPicBox.Image = Image.FromFile("F:\\Brands\\BMW4SeriesCoupe.jpg");
                    }
                    if (bmwForm.model == "BMW X4")
                    {
                        CarPicBox.Image = Image.FromFile("F:\\Brands\\BMWX4.jpg");
                    }
                    if (bmwForm.model == "BMW 7 Series")
                    {
                        CarPicBox.Image = Image.FromFile("F:\\Brands\\BMW7Series.jpg");
                    }
                    break;
                case "Volvo":
                        Volvo volvoClass = new Volvo();
                        carspec = volvoForm.counter;
                        modelname = volvoClass.model;
                        enginespecs = volvoClass.engine;
                        enginetypespec = volvoClass.enginetype;
                        horsepowerspec = volvoClass.horsepower;
                        transmissionspec = volvoClass.transimission;
                        maxspeedspec = volvoClass.maxspeed;
                        price = volvoClass.price;
                        CarNameLbl.Text = modelname[carspec];
                        carname = CarNameLbl.Text;
                        engineSpecLbl.Text = enginespecs[carspec];
                        engineTypeSpecLbl.Text = enginetypespec[carspec];
                        horsepowerSpecLbl.Text = horsepowerspec[carspec];
                        transmissionSpecLbl.Text = transmissionspec[carspec];
                        maxSpeedSpecLbl.Text = maxspeedspec[carspec];
                        if (volvoForm.model == "Volvo XC40")
                        {
                            CarPicBox.Image = Image.FromFile("F:\\Brands\\Vxc40.jpg");
                        }
                        if (volvoForm.model == "Volvo XC60")
                        {
                            CarPicBox.Image = Image.FromFile("F:\\Brands\\VXC60.jpg");
                        }
                        if (volvoForm.model == "Volvo XC90")
                        {
                            CarPicBox.Image = Image.FromFile("F:\\Brands\\Vxc90.jpg");
                        }
                        break;
                case "Ferrari":
                        Ferrari ferrariClass = new Ferrari();
                        carspec = ferrariForm.counter;
                        modelname = ferrariClass.model;
                        enginespecs = ferrariClass.engine;
                        enginetypespec = ferrariClass.enginetype;
                        horsepowerspec = ferrariClass.horsepower;
                        transmissionspec = ferrariClass.transimission;
                        maxspeedspec = ferrariClass.maxspeed;
                        price = ferrariClass.price;
                        CarNameLbl.Text = modelname[carspec];
                        carname = CarNameLbl.Text;
                        engineSpecLbl.Text = enginespecs[carspec];
                        engineTypeSpecLbl.Text = enginetypespec[carspec];
                        horsepowerSpecLbl.Text = horsepowerspec[carspec];
                        transmissionSpecLbl.Text = transmissionspec[carspec];
                        maxSpeedSpecLbl.Text = maxspeedspec[carspec];
                        if (ferrariForm.model == "Ferrari Portofino")
                        {
                            CarPicBox.Image = Image.FromFile("F:\\Brands\\Ferrari Portofino.jpg");
                        }
                        if (ferrariForm.model == "Ferrari 812 Superfast")
                        {
                            CarPicBox.Image = Image.FromFile("F:\\Brands\\Ferrari 812 Superfast.jpg");
                        }
                        break;
                case "Jaguar":
                    Jaguar jaguarClass = new Jaguar();
                    carspec = jaguarForm.counter;
                    modelname = jaguarClass.model;
                    enginespecs = jaguarClass.engine;
                    enginetypespec = jaguarClass.enginetype;
                    horsepowerspec = jaguarClass.horsepower;
                    transmissionspec = jaguarClass.transimission;
                    maxspeedspec = jaguarClass.maxspeed;
                    price = jaguarClass.price;
                    CarNameLbl.Text = modelname[carspec];
                    carname = CarNameLbl.Text;
                    engineSpecLbl.Text = enginespecs[carspec];
                    engineTypeSpecLbl.Text = enginetypespec[carspec];
                    horsepowerSpecLbl.Text = horsepowerspec[carspec];
                    transmissionSpecLbl.Text = transmissionspec[carspec];
                    maxSpeedSpecLbl.Text = maxspeedspec[carspec];
                    if (jaguarForm.model == "Jaguar E Pace")
                    {
                        CarPicBox.Image = Image.FromFile("F:\\Brands\\JaguarEPace.jpg");
                    }
                    if (jaguarForm.model == "Jaguar XE")
                    {
                        CarPicBox.Image = Image.FromFile("F:\\Brands\\JaguarXE.jpg");
                    }
                    if (jaguarForm.model == "Jaguar F Type")
                    {
                        CarPicBox.Image = Image.FromFile("F:\\Brands\\JaguarFType.jpg");
                    }
                    if (jaguarForm.model == "Jaguar XJ")
                    {
                        CarPicBox.Image = Image.FromFile("F:\\Brands\\JaguarXJ.jpg");
                    }
                    break;
                case "Ford":
                    Ford fordClass = new Ford();
                    carspec = fordForm.counter;
                    modelname = fordClass.model;
                    enginespecs = fordClass.engine;
                    enginetypespec = fordClass.enginetype;
                    horsepowerspec = fordClass.horsepower;
                    transmissionspec = fordClass.transimission;
                    maxspeedspec = fordClass.maxspeed;
                    price = fordClass.price;
                    CarNameLbl.Text = modelname[carspec];
                    carname = CarNameLbl.Text;
                    engineSpecLbl.Text = enginespecs[carspec];
                    engineTypeSpecLbl.Text = enginetypespec[carspec];
                    horsepowerSpecLbl.Text = horsepowerspec[carspec];
                    transmissionSpecLbl.Text = transmissionspec[carspec];
                    maxSpeedSpecLbl.Text = maxspeedspec[carspec];
                    if (fordForm.model == "Ford Mustang")
                    {
                        CarPicBox.Image = Image.FromFile("F:\\Brands\\FordMustang.jpg");
                    }
                    if (fordForm.model == "Ford Expedition")
                    {
                        CarPicBox.Image = Image.FromFile("F:\\Brands\\FordExpedition.jpg");
                    }
                    if (fordForm.model == "Ford Explorer")
                    {
                        CarPicBox.Image = Image.FromFile("F:\\Brands\\FordExplorer.jpg");
                    }
                    break;
                case "Lamborghini":
                    Lamborghini lamborghiniClass = new Lamborghini();
                    carspec = lamborghiniForm.counter;
                    modelname = lamborghiniClass.model;
                    enginespecs = lamborghiniClass.engine;
                    enginetypespec = lamborghiniClass.enginetype;
                    horsepowerspec = lamborghiniClass.horsepower;
                    transmissionspec = lamborghiniClass.transimission;
                    maxspeedspec = lamborghiniClass.maxspeed;
                    price = lamborghiniClass.price;
                    CarNameLbl.Text = modelname[carspec];
                    carname = CarNameLbl.Text;
                    engineSpecLbl.Text = enginespecs[carspec];
                    engineTypeSpecLbl.Text = enginetypespec[carspec];
                    horsepowerSpecLbl.Text = horsepowerspec[carspec];
                    transmissionSpecLbl.Text = transmissionspec[carspec];
                    maxSpeedSpecLbl.Text = maxspeedspec[carspec];
                    if (lamborghiniForm.model == "Lamborghini Urus")
                    {
                        CarPicBox.Image = Image.FromFile("F:\\Brands\\LamborghiniUrus.jpg");
                    }
                    if (lamborghiniForm.model == "Lamborghini Hurucan")
                    {
                        CarPicBox.Image = Image.FromFile("F:\\Brands\\LamborghiniHuracan.jpg");
                    }
                    if (lamborghiniForm.model == "Lamborghini Aventador")
                    {
                        CarPicBox.Image = Image.FromFile("F:\\Brands\\LamborghiniAventador.jpg");
                    }
                    break;
                case "Audi":
                    Audi audiClass = new Audi();
                    carspec = audiForm.counter;
                    modelname = audiClass.model;
                    enginespecs = audiClass.engine;
                    enginetypespec = audiClass.enginetype;
                    horsepowerspec = audiClass.horsepower;
                    transmissionspec = audiClass.transimission;
                    maxspeedspec = audiClass.maxspeed;
                    price = audiClass.price;
                    CarNameLbl.Text = modelname[carspec];
                    carname = CarNameLbl.Text;
                    engineSpecLbl.Text = enginespecs[carspec];
                    engineTypeSpecLbl.Text = enginetypespec[carspec];
                    horsepowerSpecLbl.Text = horsepowerspec[carspec];
                    transmissionSpecLbl.Text = transmissionspec[carspec];
                    maxSpeedSpecLbl.Text = maxspeedspec[carspec];
                    if (audiForm.model == "Audi A4")
                    {
                        CarPicBox.Image = Image.FromFile("F:\\Brands\\Audi A4.jpg");
                    }
                    if (audiForm.model == "Audi RS5")
                    {
                        CarPicBox.Image = Image.FromFile("F:\\Brands\\Audi RS5.jpg");
                    }
                    if (audiForm.model == "Audi RS6")
                    {
                        CarPicBox.Image = Image.FromFile("F:\\Brands\\Audi RS6.jpg");
                    }
                    break;
                case "Honda":
                    Honda hondaClass = new Honda();
                    carspec = hondaForm.counter;
                    modelname = hondaClass.model;
                    enginespecs = hondaClass.engine;
                    enginetypespec = hondaClass.enginetype;
                    horsepowerspec = hondaClass.horsepower;
                    transmissionspec = hondaClass.transimission;
                    maxspeedspec = hondaClass.maxspeed;
                    price = hondaClass.price;
                    CarNameLbl.Text = modelname[carspec];
                    carname = CarNameLbl.Text;
                    engineSpecLbl.Text = enginespecs[carspec];
                    engineTypeSpecLbl.Text = enginetypespec[carspec];
                    horsepowerSpecLbl.Text = horsepowerspec[carspec];
                    transmissionSpecLbl.Text = transmissionspec[carspec];
                    maxSpeedSpecLbl.Text = maxspeedspec[carspec];
                    if (hondaForm.model == "Honda CR-V")
                    {
                        CarPicBox.Image = Image.FromFile("F:\\Brands\\Honda CR-V.jpg");
                    }
                    if (hondaForm.model == "Honda BR-V")
                    {
                        CarPicBox.Image = Image.FromFile("F:\\Brands\\Honda BR-V.jpg");
                    }
                    if (hondaForm.model == "Honda Odyssey")
                    {
                        CarPicBox.Image = Image.FromFile("F:\\Brands\\Honda Odyssey.jpg");
                    }
                    break;
                case "Porsche":
                    Porsche porscheClass = new Porsche();
                    carspec = porscheForm.counter;
                    modelname = porscheClass.model;
                    enginespecs = porscheClass.engine;
                    enginetypespec = porscheClass.enginetype;
                    horsepowerspec = porscheClass.horsepower;
                    transmissionspec = porscheClass.transimission;
                    maxspeedspec = porscheClass.maxspeed;
                    price = porscheClass.price;
                    CarNameLbl.Text = modelname[carspec];
                    carname = CarNameLbl.Text;
                    engineSpecLbl.Text = enginespecs[carspec];
                    engineTypeSpecLbl.Text = enginetypespec[carspec];
                    horsepowerSpecLbl.Text = horsepowerspec[carspec];
                    transmissionSpecLbl.Text = transmissionspec[carspec];
                    maxSpeedSpecLbl.Text = maxspeedspec[carspec];
                    if (porscheForm.model == "Porsche Cayenne")
                    {
                        CarPicBox.Image = Image.FromFile("F:\\Brands\\Porsche Cayenne.png");
                    }
                    if (porscheForm.model == "Porsche Macan")
                    {
                        CarPicBox.Image = Image.FromFile("F:\\Brands\\Porsche Macan.jpg");
                    }
                    break;
                case "Dodge":
                    Dodge dodgeClass = new Dodge();
                    carspec = dodgeForm.counter;
                    modelname = dodgeClass.model;
                    enginespecs = dodgeClass.engine;
                    enginetypespec = dodgeClass.enginetype;
                    horsepowerspec = dodgeClass.horsepower;
                    transmissionspec = dodgeClass.transimission;
                    maxspeedspec = dodgeClass.maxspeed;
                    price = dodgeClass.price;
                    CarNameLbl.Text = modelname[carspec];
                    carname = CarNameLbl.Text;
                    engineSpecLbl.Text = enginespecs[carspec];
                    engineTypeSpecLbl.Text = enginetypespec[carspec];
                    horsepowerSpecLbl.Text = horsepowerspec[carspec];
                    transmissionSpecLbl.Text = transmissionspec[carspec];
                    maxSpeedSpecLbl.Text = maxspeedspec[carspec];
                    if (dodgeForm.model == "Dodge Charger RT")
                    {
                        CarPicBox.Image = Image.FromFile("E:\\Brands\\Dodge Charger RT.jfif");
                    }
                    if (dodgeForm.model == "Dodge Charger SXT")
                    {
                        CarPicBox.Image = Image.FromFile("F:\\Brands\\Dodge Charger SXT.jfif");
                    }
                    if (dodgeForm.model == "Dodge Charger GT")
                    {
                        CarPicBox.Image = Image.FromFile("E:\\Brands\\Dodge Charger GT.jfif");
                    }
                    break;
            }
        }

        private void backPicBox_Click(object sender, EventArgs e)
        {
            switch (CarBrands.carbrand)
            {
                case "BMW":
                    bmwForm bmw = new bmwForm();
                    this.Hide();
                    bmw.Show();
                    break;

                case "Volvo":
                    volvoForm volvo = new volvoForm();
                    this.Hide();
                    volvo.Show();
                    break;

                case "Ferrari":
                    ferrariForm ferrari = new ferrariForm();
                    this.Hide();
                    ferrari.Show();
                    break;
                case "Jaguar":
                    jaguarForm jaguar = new jaguarForm();
                    this.Hide();
                    jaguar.Show();
                    break;
                case "Ford":
                    fordForm ford = new fordForm();
                    this.Hide();
                    ford.Show();
                    break;
                case "Lamborghini":
                    lamborghiniForm lamborghini = new lamborghiniForm();
                    this.Hide();
                    lamborghini.Show();
                    break;
                case "Audi":
                    audiForm audi = new audiForm();
                    this.Hide();
                    audi.Show();
                    break;
                case "Honda":
                    hondaForm honda = new hondaForm();
                    this.Hide();
                    honda.Show();
                    break;
                case "Porsche":
                    porscheForm porsche = new porscheForm();
                    this.Hide();
                    porsche.Show();
                    break;
                case "Dodge":
                    dodgeForm dodge = new dodgeForm();
                    this.Hide();
                    dodge.Show();
                    break;
            }
        }
        public static double cashprice = 0, oneyearprice = 0, twoyearprice = 0;

        private void cashRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            PriceTxtBox.Text = Convert.ToString("P " +cashprice);
            price = PriceTxtBox.Text;
        }

        private void CashOutBtn_Click(object sender, EventArgs e)
        {
            recieptForm receipt = new recieptForm();
            this.Hide();
            receipt.Show();
        }
        private void oneYrInstRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            PriceTxtBox.Text = Convert.ToString("P " + oneyearprice);
            price = PriceTxtBox.Text;
        }
        private void twoYrInstRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            PriceTxtBox.Text = Convert.ToString("P " + twoyearprice);
            price = PriceTxtBox.Text;
        }
        public static string price = " ";
        public static string name = " ";
        public static string carname = " ";
    }
}
