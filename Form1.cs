//ZacK Zepezauer
//12-2-22
//CSI 122 Final

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Prog_122_Final.Car;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Prog_122_Final
{
    public partial class Form1 : Form
    {
        //Global lists for owners and cars
        List<Owner> owners = new List<Owner>();
        List<Car> cars = new List<Car>();

        public Form1()
        {
            InitializeComponent();
            //Preload call
            Preload();
            
        } // Form1()

        //Preload to be called in form 1
        public void Preload()
        {
            //Call combobox population methods first
            FillYearComboBox();
            FillMileageComboBox();
            //Populate owners second so it can be referenced in methods prior to generation of cars method
            PopulateOwners(owners);
            //Last call generate cars method which contains display owners and display cars methods
            GenerateCars(20);
        }

        //Method to format car in Listview (populating the listview with all cars is done in another method)
        public void FormatCarInfo(Car car)
        {
            //Declare array and pass in all fields from Car class
            string[] cars =
            {
                car.Make.ToString(),
                car.Model,
                car.Year.ToString(),
                car.HasGPS.ToString(),
                car.HasBackUpCam.ToString(),
                car.Mileage.ToString()
            };

            //Declare listview item variable and pass in cars array
            ListViewItem listViewItem = new ListViewItem(cars);

            //Connect listview item to display
            lvMainDisplay.Items.Add(listViewItem);
        }

        //Method to randomly populate cars list and also randomly assign to cars list of each owner, and pass in an int variable to
        //allow us to select how many cars we want generated when callin inside preload method
        public void GenerateCars(int carsPopulate)
        {
            //Generate new instance of a random
            Random random = new Random();

            //Create a string of car models to use in population
            string[] models = { "Outback", "Forester", "Tacoma", "Impreza", "4Runner", "Supra", "Civic", "CRV", "Skyline", "XTerra", "Brat", "Frontier" };
            
            //Loop to run the lenght of int selected in preload
            for (int i = 0; i < carsPopulate; i++)
            {
                //Declare make variable and generate random (I got very lucky with this)
                Car.MAKE make = (Car.MAKE)random.Next(Enum.GetNames(typeof(Car.MAKE)).Length);

                //Declare int for random generation of models in models array
                int modelIndex = random.Next(models.Length);
                //Declare model variable and attach to index random
                string model = models[modelIndex];

                //Declare year variable and generate random from 1970-2022
                int year = random.Next(1970, 2022);

                //Declare GPS and Cam bool variables and generate random (50% chance random from 2 will == 1)
                bool hasGPS = random.Next(2) == 1;
                bool hasBackUpCam = random.Next(2) == 1;

                //Declare mileage variable and generate random between 0-200000
                int mileage = random.Next(0, 200000);

                //Use declared random variables to create a random car
                Car car = new Car(make, model, year, hasGPS, hasBackUpCam, mileage);
                //Add car to main car list
                cars.Add(car);

                //Declare int for random owner index
                int ownerIndex = random.Next(owners.Count);
                //Add car at previously created random owner index
                owners[ownerIndex].AddCar(car);
            }

            //Call method to display owners (in both boxes)
            DisplayOwnersDetailed(owners);

            //Call display cars method which populates Listview
            DisplayCars(cars);
        }

        //Method to display cars in listview that passes in cars list
        public void DisplayCars(List<Car> cars)
        {
            //Prevents listview from becoming populated by extra results
            lvMainDisplay.Items.Clear();
            
            //Loop to pass through each car in list
            foreach (Car car in cars)
            {
                //Call the format car method each time loop runs to populate listview with
                //specified amount of cars in generate car method
                FormatCarInfo(car);
            }
            
            //Call mileage method in here so it changes as the list changes
            DisplayAverageMileage(cars);

            //Method to resize columns in listview
            lvMainDisplay.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        //Method to display owners in both listboxes and passes in owners list
        public void DisplayOwnersDetailed(List<Owner> owners)
        {
            //Prevents both boxes from becoming populated by extra results
            lbFilterOptionsOwners.Items.Clear();
            lbAddCarOwner.Items.Clear();

            //Loop to run through owners list and display them in filter by owner box
            for (int i = 0; i < owners.Count; i++)
            {
                //Populates box with name, amount of cars associated with owner, and average mileage of 
                //cars owned by owner to 2 decimal points
                lbFilterOptionsOwners.Items.Add($"{owners[i].Name}" + $" -- {owners[i].cars.Count} Cars" + $" -- Average Miles: {owners[i].AverageMileage().ToString("#.##")}" );
            }

            //Loop to run through owners list and display in add car box
            for (int i = 0; i < owners.Count; i++)
            {
                //Populates box with only name
                lbAddCarOwner.Items.Add(owners[i].Name);
            }
        }

        //Method to calculate display the average mileage of cars in cars list while passing in cars list
        public void DisplayAverageMileage(List<Car> cars)
        {
            //Declare sum and average variables (sum starts at 0 so it can be added to)
            double sum = 0;
            double average;
            
            //Loop through car list
            foreach (Car car in cars)
            {
                //Add car mileage to sum with each pass through loop
                sum += car.Mileage;
            }

            //Calculate average dividing sum by length of cars list
            average = sum / cars.Count;

            //Display average in text box to two decimal points
            tbAverageMileage.Text = average.ToString("#.##");
        }

        //Method to populate owners list passing in owners list
        public void PopulateOwners(List<Owner> owners)
        {
            //Declare array variable for an array of names
            string[] ownersNames =
            {
                "Zack",
                "Will",
                "Justin",
                "Emily",
                "Jeremy",
                "Jae"
            };

            //Loop through array
            for (int i = 0; i < ownersNames.Length; i++)
            {
                //Add names from array to owner list with each pass
                owners.Add(new Owner(ownersNames[i]));
            }
        }
            
        //Basic add car method that passes in a car
        public void AddCar(Car car)
        {
            //Adds car to list
            cars.Add(car);
        }
        
        //Button method to add a car to list of cars and attach to an owner
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            //Declare enumerator variable calling enumerator in the process
            Car.MAKE make;

            //Try catch to make sure user is inputting strings and ints where necessary, etc.
            try
            {
                // if/else if/else statement to check for MAKE radio button selection
                if (rbAddCarSubaru.Checked)
                {
                    //Assign make to make variable
                    make = MAKE.Subaru;
                }
                else if (rbAddCarToyota.Checked)
                {
                    //Assign make to make variable
                    make = MAKE.Toyota;
                }
                else if (rbAddCarHonda.Checked)
                {
                    //Assign make to make variable
                    make = MAKE.Honda;
                }
                else
                {
                    //Assign make to make variable
                    make = MAKE.Nissan;
                }

                //Declare string variable for model input
                string addModel = tbAddCarModel.Text;

                //Declare int variable for selection in combobox
                int year = int.Parse(cbAddCarYear.Text);

                //Declare bool variables for GPS and Cam checkboxes
                bool hasGPS = chkAddCarGPS.Checked;
                bool hasCam = chkAddCarBackUpCam.Checked;

                //Declare int variable for mileage input
                int mileage = int.Parse(tbAddCarMileage.Text);

                //Add car to list by passing in all variables declared
                Car newCar = new Car(make, addModel, year, hasGPS, hasCam, mileage);

                // if/else if/else statement to check for selection in add car by owner listbox
                //Because still in try, added car can now be added to an owner
                if (lbAddCarOwner.Text == "Zack")
                {
                    //Add owner at index of name specified
                    owners[0].AddCar(newCar);
                }
                else if (lbAddCarOwner.Text == "Will")
                {
                    //Add owner at index of name specified
                    owners[1].AddCar(newCar);
                }
                else if (lbAddCarOwner.Text == "Justin")
                {
                    //Add owner at index of name specified
                    owners[2].AddCar(newCar);
                }
                else if (lbAddCarOwner.Text == "Emily")
                {
                    //Add owner at index of name specified
                    owners[3].AddCar(newCar);
                }
                else if (lbAddCarOwner.Text == "Jeremy")
                {
                    //Add owner at index of name specified
                    owners[4].AddCar(newCar);
                }
                else
                {
                    //Add owner at index of name not specified
                    owners[5].AddCar(newCar);
                }

                //Call Add car method to add completed car to full list
                AddCar(newCar);
            }
            //Catch for user error
            catch
            {
                //Inform user if filled out incorrectly
                MessageBox.Show("Please enter valid information");
            }

            //Call Display cars method for updated list
            DisplayCars(cars);

            //Call Display owners method for updated list to show new mileage and car count in listbox
            DisplayOwnersDetailed(owners);
        }

        //Method to filter listview display by chosen owners list of cars by passing in owners and int for use in button
        public List<Owner> ByOwner(int index, List<Owner> owners)
        {
            // if/else if/else statement to check for selected owner by index in listbox
            if (lbFilterOptionsOwners.SelectedIndex == 0)
            {
                //Display cars of owner at specified index
                DisplayCars(owners[0].Cars);
            }
            else if (lbFilterOptionsOwners.SelectedIndex == 1)
            {
                //Display cars of owner at specified index
                DisplayCars(owners[1].Cars);
            }
            else if (lbFilterOptionsOwners.SelectedIndex == 2)
            {
                //Display cars of owner at specified index
                DisplayCars(owners[2].Cars);
            }
            else if (lbFilterOptionsOwners.SelectedIndex == 3)
            {
                //Display cars of owner at specified index
                DisplayCars(owners[3].Cars);
            }
            else if (lbFilterOptionsOwners.SelectedIndex == 4)
            {
                //Display cars of owner at specified index
                DisplayCars(owners[4].Cars);
            }
            else if (lbFilterOptionsOwners.SelectedIndex == 5)
            {
                //Display cars of owner at specified index
                DisplayCars(owners[5].Cars);
            }
            else
            {
                //Inform user that if they want to filter by owner they need to select an owner
                MessageBox.Show("Please select an owner");
            }
            
            //Return selected owner
            return owners;
        }

        //Button method to filter by owner
        private void btnFilterByOwner_Click(object sender, EventArgs e)
        {
            //Declare int variable associated with index in listbox
            int index = lbAddCarOwner.SelectedIndex;

            //Call filter by owner method passsing in owners list and index selection
            ByOwner(index, owners);
        }

        //Method to filter listview display by chosen make by passing in cars list and make enumerator
        public List<Car> ByMake(Car.MAKE makes, List<Car> cars)
        {
            //Declare new car list to add filtered results to
            List <Car> result = new List<Car>();

            //Loop to cycle through cars list
            foreach (Car car in cars)
            {
                //If statement to check if make of car in list is same as makes variable
                if (car.Make == makes)
                {
                    //Adds car to new list if statement is true
                    result.Add(car);
                }
            }

            //Return new list
            return result;
        }

        //Button method to filter cars list by make selection
        private void btnFilterByMake_Click(object sender, EventArgs e)
        {
            //Create new list variables for each make while calling the make filter method, pass in each make type
            List<Car> carslistS = ByMake(Car.MAKE.Subaru, cars);
            List<Car> carslistT = ByMake(Car.MAKE.Toyota, cars);
            List<Car> carslistH = ByMake(Car.MAKE.Honda, cars);
            List<Car> carslistN = ByMake(Car.MAKE.Nissan, cars);

            // if/else if/else statement to check for radio button selection associated with each make, then display associated
            //list declared above
            if (rbFilterOptionsSubaru.Checked)
            {
                DisplayCars(carslistS);
            }
            else if (rbFilterOptionsToyota.Checked)
            {
                DisplayCars(carslistT);
            }
            else if (rbFilterOptionsHonda.Checked)
            {
                DisplayCars(carslistH);
            }
            else
            {
                DisplayCars(carslistN);
            }
        }

        //Method to populate mileage filter options combobox
        public void FillMileageComboBox()
        {
            //For loop that goes from 0 to 100000 by increments of 10000
            for (int i = 0; i <= 100000; i += 10000)
            {
                //Populate mileage combobox with each pass of loop
                cbFilterOptionsMileage.Items.Add(i);
            }
            
            //Display mileage at index of 0 so combobox shows a value on load
            cbFilterOptionsMileage.SelectedIndex = 0;
        }

        //Method to filter listview display above selected mileage in combobox
        public List<Car> ByMileage(int miles, List<Car> cars)
        {
            //Declare new car list to add filtered results to
            List<Car> result = new List<Car>();

            //Loop to run through list of cars
            foreach (Car car in cars)
            {
                //If statement to check if mileage of car in list is higher than selected mileage
                if (car.Mileage >= miles)
                {
                    //Add to new list if statement is true
                    result.Add(car);
                }
            }
            
            //Return new list
            return result;
        }
        
        //Button method to filter cars list by mileage
        private void btnFilterByMileage_Click(object sender, EventArgs e)
        {
            //Declare int variable to associate with combobox selection
            int miles = int.Parse(cbFilterOptionsMileage.Text);

            //Declare cars list variable and equate to mileage filter method that calls car list and combobox selection
            List<Car> filteredByMiles = ByMileage(miles, cars);
            
            //Display modified list
            DisplayCars(filteredByMiles);
        }

        //Method to populate year comboboxes
        public void FillYearComboBox()
        {
            //for loop to start at 1970 and end at 2022 by increments of 1
            for (int i = 1970; i <= 2022; i++)
            {
                //Populate all year comboboxes
                cbFilterOptionsFrom.Items.Add(i);
                cbFilterOptionsTo.Items.Add(i);
                cbAddCarYear.Items.Add(i);
            }

            //Set selected indexes on load
            cbAddCarYear.SelectedIndex = 0;
            cbFilterOptionsFrom.SelectedIndex = 0;
            cbFilterOptionsTo.SelectedIndex = cbFilterOptionsTo.Items.Count - 1;
        }

        //Method to filter cars list by year range passing in to and from ints, and cars list
        public List<Car> ByYear(int from, int to, List<Car> cars)
        {
            //Declare new car list to add filtered results to
            List<Car> result = new List<Car>();
            
            //Loop through cars list
            foreach(Car car in cars)
            {
                //If statement to check if year is between range of selections
                if(car.Year >= from && car.Year <= to)
                {
                    //Add to new list if true
                    result.Add(car);
                }
            }

            //Return new list
            return result;
        }
        
        //Button method to filter cars by year range
        private void btnFilterByYear_Click(object sender, EventArgs e)
        {
            //Declare int variables for combobox selections
            int from = int.Parse(cbFilterOptionsFrom.Text);
            int to = int.Parse(cbFilterOptionsTo.Text);

            //Declare cars list variable and equate to year filter method that calls car list and combobox selections
            List<Car> filteredByYear = ByYear(from, to, cars);
            
            //Display modified list
            DisplayCars(filteredByYear);
        }

        //Reset button method to clear filtered results
        private void btnReset_Click(object sender, EventArgs e)
        {
            //Just re-displays full cars list
            DisplayCars(cars);
        }

        
    } // class

} // namespace
