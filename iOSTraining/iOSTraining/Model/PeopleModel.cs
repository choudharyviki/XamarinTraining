using System;
using System.Collections.Generic;
using UIKit;

namespace iOSTraining.Model
{
    public class PeopleModel:UIPickerViewModel
    {
        int index = 0;
        public EventHandler Valuechange;
        public string Selectedvalue;

        public List<string> nameOfPeople;
       
        public PeopleModel(List<string> nameOfPeople)
        {
            this.nameOfPeople = nameOfPeople;
            //nameOfPeople.Add("Amy Burn");
            //nameOfPeople.Add("Kevin Mullians");
            //nameOfPeople.Add("craige Dunn");
            //nameOfPeople.Add("daivd Burn");
            //nameOfPeople.Add("mark Burn");
            //nameOfPeople.Add("Tom Burn");

            
        }
        public  string DefaultPickerValue()
        {
            return nameOfPeople[0].ToString();
        }

        public override nint GetComponentCount(UIPickerView pickerView)
        {
            return 1;
        }
        public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
        {
            return nameOfPeople.Count;
        }
        public override string GetTitle(UIPickerView pickerView, nint row, nint component)
        {
            return nameOfPeople[(int)row];
        }
        public override void Selected(UIPickerView pickerView, nint row, nint component)
        {
            //base.Selected(pickerView, row, component);
            var nameofpeople = nameOfPeople[(int)row];
            Selectedvalue = nameofpeople;
            Valuechange?.Invoke(null, null);
            
        }
    }
}
