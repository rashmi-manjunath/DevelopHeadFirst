using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter7Program4
{
    public partial class Form1 : Form
    {
        int Moves;

        Location currentLocation;

        RoomWithDoor livingRoom;
        RoomWithHidingPlace diningRoom;
        RoomWithDoor kitchen;
        Room stairs;
        RoomWithHidingPlace hallWay;
        RoomWithHidingPlace bathRoom;
        RoomWithHidingPlace masterBedRoom;
        RoomWithHidingPlace secondBedRoom;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        OutsideWithHidingPlace garden;
        OutsideWithHidingPlace driveway;

        Opponent opponent;

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            opponent = new Opponent(frontYard);
            ResetGame(false);
        }

        private void MoveToNewLocation(Location newLocation)
        {
            Moves++;
            currentLocation = newLocation;
            RedrawForm();
        }

        private void RedrawForm()
        {
            exists.Items.Clear();
            for (int i = 0; i < currentLocation.Exists.Length; i++)
                exists.Items.Add(currentLocation.Exists[i].Name);
            exists.SelectedIndex = 0;
            description.Text = currentLocation.Description + "\r \n(move # " + Moves + " )";
            if (currentLocation is IHidingPlace)
            {
                IHidingPlace hidingPlace = currentLocation as IHidingPlace;
                check.Text = "check " + hidingPlace.HidingPlace;
                check.Visible = true;
            }
            else
                check.Visible = false;
            if (currentLocation is IHasExteriorDoor)
                goThroughTheDoor.Visible = true;
            else
                goThroughTheDoor.Visible = false;
        }


        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Living Room", " an antique carpet"," inside the closet", " an oak door with a brass knob");
            diningRoom = new RoomWithHidingPlace("Dining Room", "a crystal chandelier","in the tall armoire");
            kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances","in the cabinet", "a screen door");
            stairs = new Room("stairs", "a wooden bannister");
            hallWay = new RoomWithHidingPlace("Upstairs Hallway", "a picture of a dog", "in the closet");
            bathRoom = new RoomWithHidingPlace("Bathroom","a sink and a toilet","in the shower");
            masterBedRoom = new RoomWithHidingPlace("Master Bed Room", "a large bed", "under the bed");
            secondBedRoom = new RoomWithHidingPlace("Second Bedroom", "a small bed", "under the bed");


            frontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass knob");
            backYard = new OutsideWithDoor("Back Yard", true, "a screen door");
            garden = new OutsideWithHidingPlace("Garden", false ,"inside the shed");
            driveway = new OutsideWithHidingPlace("Driveway", true, "in the garbage");


            diningRoom.Exists = new Location[] { livingRoom, kitchen };
            livingRoom.Exists = new Location[] { diningRoom ,stairs};
            kitchen.Exists = new Location[] { diningRoom };
            stairs.Exists = new Location[] { livingRoom, hallWay };
            hallWay.Exists = new Location[] { stairs, bathRoom, masterBedRoom, secondBedRoom };
            bathRoom.Exists = new Location[] { hallWay };
            masterBedRoom.Exists = new Location[] { hallWay };
            secondBedRoom.Exists = new Location[] { hallWay };
            frontYard.Exists = new Location[] { backYard, garden ,driveway };
            backYard.Exists = new Location[] { frontYard, garden, driveway};
            garden.Exists = new Location[] { backYard, frontYard};
            driveway.Exists = new Location[] { backYard, frontYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;
            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }


        private void ResetGame(bool displayMessage)
        {
            if(displayMessage)
            {
                MessageBox.Show("You found me in " + Moves + " moves!");
                IHidingPlace foundLocation = currentLocation as IHidingPlace;
                description.Text = "You found your opponent in " + Moves + " moves! He was hiding " + foundLocation.HidingPlace + " .";
            }
            Moves = 0;
            hide.Visible = true;
            button1.Visible = false;
            check.Visible = false;
            goThroughTheDoor.Visible = false;
            exists.Visible = false;
        }

        private void MoveToANewLocation(Location newLocation)
        {
            currentLocation = newLocation;

            exists.Items.Clear();
            for (int i = 0; i < currentLocation.Exists.Length; i++)
                exists.Items.Add(currentLocation.Exists[i].Name);
            exists.SelectedIndex = 0;

            description.Text = currentLocation.Description;

            if (currentLocation is IHasExteriorDoor)
                goThroughTheDoor.Visible = true;
            else
                goThroughTheDoor.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exists[exists.SelectedIndex]);
        }

        private void goThroughTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }

        private void check_Click(object sender, EventArgs e)
        {
            Moves++;
            if (opponent.Check(currentLocation))
                ResetGame(true);
            else
                RedrawForm();
        }

        private void hide_Click(object sender, EventArgs e)
        {
            hide.Visible = false;

            for(int i=1;i<=10;i++)
            {
                opponent.Move();
                description.Text = i + "...";
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }
            description.Text = "Ready or not,here I come!";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            button1.Visible = true;
            exists.Visible = true;
            MoveToANewLocation(livingRoom);
        }
    }
}
