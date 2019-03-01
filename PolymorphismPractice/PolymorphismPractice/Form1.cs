using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolymorphismPractice
{
    public partial class Form1 : Form
    {
        Lokacija currentLocation;
        Opponent oponnent;

        Room stairs;
        RoomWithDoor kitchen, livingRoom;
        RoomWithHiddingPlace dinningRoom, upStairsHallway, masterBedroom, bathroom, secondBedroom;

        OutsideWithDoor frontYard, backYard;
        OustsideWithHiddingPlace driveWay, garden;

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (oponnent.Check(currentLocation))
            {
                MessageBox.Show("You found him ");
                ResetTheGame(true);
            }
            else
            {
                MessageBox.Show("He is not here");
                RedrawTheForm();
            }
        }

        private void GoThroughThatDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasExteriorDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasExteriorDoor.DoorLocation);
        }

        private void GoHerebtn_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[ExitscomboBox1.SelectedIndex]);
        }

        private void Hidebutton2_Click(object sender, EventArgs e)
        {
            Hidebutton2.Visible = false;

            
            for (int i = 0; i <= 10; i++)
            {
                oponnent.Move();
                description.Text = i + "...";
                Application.DoEvents();
                System.Threading.Thread.Sleep(300);

            }
            description.Text += "Ready or not here i come";
            Application.DoEvents();
            System.Threading.Thread.Sleep(2000);

            ExitscomboBox1.Visible = true;
            GoHerebtn.Visible = true;
            MoveToANewLocation(livingRoom);
        }

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            oponnent = new Opponent(livingRoom);
            ResetTheGame(false);
        }

        public void CreateObjects()
        {
            stairs = new Room("Stairs", "Wooden banister");

            //With hiding places
            dinningRoom = new RoomWithHiddingPlace("Dinning room", "A table for dinning", new string[] { "the closet", "tall armoire" });
            upStairsHallway = new RoomWithHiddingPlace("Upstairs hallway", "Picture of dog", new string[] { "closet" });
            masterBedroom = new RoomWithHiddingPlace("Master bedroom", "Large bed", new string[] { "under big bed", "behind curtain" });
            secondBedroom = new RoomWithHiddingPlace("Second bedroom", "Small bed", new string[] { "under small bed", "under working desk" });
            bathroom = new RoomWithHiddingPlace("Bathroom", "Sink and toilet", new string[] { "In shower" });

            garden = new OustsideWithHiddingPlace("Garden", true, new string[] { "behind bush", "behind huge grass" });
            driveWay = new OustsideWithHiddingPlace("Driveway", false, new string[] { "garage", "behind car" });

            livingRoom = new RoomWithDoor("Living room", "A antique carpet", "Wooden door with a brass knob", new string[] { "inside the closet", "behind the couch" });
            kitchen = new RoomWithDoor("Kitchen ", "A room full of metal appliances", "A glass dooor", new string[] { "under the table ", "under kitchen sink" });

            //With no hidding place
            frontYard = new OutsideWithDoor("Front yard", false, "Wooden door with a brass knob");
            backYard = new OutsideWithDoor("Back yard", true, "A glass dooor");

            //Room exits
            stairs.Exits = new Lokacija[] { livingRoom, upStairsHallway };
            masterBedroom.Exits = new Lokacija[] { upStairsHallway };
            secondBedroom.Exits = new Lokacija[] { upStairsHallway };
            bathroom.Exits = new Lokacija[] { upStairsHallway };
            livingRoom.Exits = new Lokacija[] { stairs, dinningRoom };
            kitchen.Exits = new Lokacija[] { dinningRoom };
            dinningRoom.Exits = new Lokacija[] { livingRoom, kitchen };
            upStairsHallway.Exits = new Lokacija[] { masterBedroom, secondBedroom, bathroom, stairs };

            //Outside exits
            driveWay.Exits = new Lokacija[] { frontYard, backYard };
            garden.Exits = new Lokacija[] { frontYard, backYard };
            frontYard.Exits = new Lokacija[] { driveWay, livingRoom, garden };
            backYard.Exits = new Lokacija[] { driveWay, kitchen, garden };

            //Rooms and Outside classes that implements IHadExteriorDoor interfejs
            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;
            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = frontYard;
        }

        public void MoveToANewLocation(Lokacija newLocation)
        {
            moves++;
            currentLocation = newLocation;
            RedrawTheForm();
        }

        int moves;
        Random rnd = new Random();

        public void RedrawTheForm()
        {
            ExitscomboBox1.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
            {
                ExitscomboBox1.Items.Add(currentLocation.Exits[i].Name);
                ExitscomboBox1.SelectedIndex = 0;
            }
            description.Text = currentLocation.Description + "\r\n Moves " + moves + ".";
            if (currentLocation is IHiddingPlaces)
            {
                IHiddingPlaces hiddingPlaces = currentLocation as IHiddingPlaces;
                checkButton.Visible = true;

                string hidingplacesarray = "";
                for (int i = 0; i < hiddingPlaces.HiddingPlaceName.Length; i++)
                {
                    hidingplacesarray += hiddingPlaces.HiddingPlaceName[i].ToLower();
                    if (i != hiddingPlaces.HiddingPlaceName.Length - 1)
                    {
                        hidingplacesarray += ", ";
                    }
                }
                hidingplacesarray += ".";
                checkButton.Text = "Check " + hidingplacesarray;
            }
            else
            {
                checkButton.Visible = false;
            }
            if (currentLocation is IHasExteriorDoor)
            {
                GoThroughThatDoor.Visible = true;
            }
            else
            {
                GoThroughThatDoor.Visible = false;
            }

        }

        public void ResetTheGame(bool opponentFound)
        {
            if (opponentFound)
            {
                MessageBox.Show("You found me in " + moves);
                IHiddingPlaces hiddingPlaces = currentLocation as IHiddingPlaces;
                int rndNum = rnd.Next(hiddingPlaces.HiddingPlaceName.Length);
                description.Text = "You found your opponent in " + moves + " moves! He was hidding in " + hiddingPlaces.HiddingPlaceName[rndNum];
            }
            moves = 0;
            Hidebutton2.Visible = true;
            ExitscomboBox1.Visible = false;
            GoHerebtn.Visible = false;
            GoThroughThatDoor.Visible = false;
            checkButton.Visible = false;
        }
    }
}
