using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.WindowStripControls;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.PropertyGridItems;
using TestStack.White.UIItems.Custom;
using TestStack.White.UIItems.WPFUIItems;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace White
{
    public class NewPokerTableGroupWindow : WindowObject
    {
        internal NewPokerTableGroupWindow(Window window) : base (window) { }
   
        
        #region General Settings
        private TextBox TableName => TextBox("nameEdit");
        private ListBox TableTags => _window.Get<ListBox>(SearchCriteria.ByAutomationId("tagsTokenEdit")); //Not Realised
        private ComboBox TableCurrency => ComboBox("moneyTypeEdit");
        private TextBox TableGameType => TextBox("gameTypeEdit"); //Not Realised
        private Panel StakesBlock => _window.Get<Panel>(SearchCriteria.ByAutomationId("stakesTextRangeControl")); 
        private TextBox StakesLow => StakesBlock.Get<TextBox>(SearchCriteria.ByAutomationId("fromTextEdit")); 
        private TextBox StakesHigh => StakesBlock.Get<TextBox>(SearchCriteria.ByAutomationId("toTextEdit")); 
        private TextBox TableAnte => TextBox("anteTextEdit");
        private Panel BuyInBlock => _window.Get<Panel>(SearchCriteria.ByAutomationId("buyInTextRangeControl")); 
        private TextBox BuyInMin => BuyInBlock.Get<TextBox>(SearchCriteria.ByAutomationId("fromTextEdit")); 
        private TextBox BuyInMax => BuyInBlock.Get<TextBox>(SearchCriteria.ByAutomationId("toTextEdit")); 
        private ComboBox TableSeats => ComboBox("seatsComboBoxEdit");
        private TextBox TableCap => TextBox("capTextEdit");
        private ComboBox TableRake => ComboBox("rakeStructureEdit");
        private ComboBox TableStraddle => ComboBox("straddleComboBoxEdit");
        #endregion
        #region Table Creation Settings
        private Panel TableOpenBlock => _window.Get<Panel>(SearchCriteria.ByAutomationId("keepOpenNumericRangeControl")); 
        private TextBox TableMin => TableOpenBlock.Get<TextBox>(SearchCriteria.ByAutomationId("fromTextEdit"));
        private TextBox TableMax => TableOpenBlock.Get<TextBox>(SearchCriteria.ByAutomationId("toTextEdit"));
        private TextBox TableFreeSeats => TextBox("freeSeatsTextEdit");
        #endregion
        #region Additional Settings
        private ComboBox TableBBJ => ComboBox("badBeatJackpotComboBox");
        private CheckBox AnonymTable => CheckBox("anonymousTableCheckEdit");
        private CheckBox RITTable => CheckBox("runItTwiceCheckEdit");
        private CheckBox TableDP => CheckBox("disconnectionProtectionEdit");
        #endregion
        #region Accessibility Settings
        private TextBox TablePassword => TextBox("passwordTextEdit");
        private ComboBox TableUACRule => ComboBox("accessRuleEdit");
        private ComboBox TableReconnectRule => ComboBox("reconnectionAccessRuleComboBoxEdit");
        private ComboBox TableChatRule => ComboBox("chatAccesabilityEdit");
        #endregion
        #region Timeout Settings
        private TextBox TableActionTimeout =>TextBox("actionTimeoutSpinEdit");
        private TextBox TableTimeBankAmount => TextBox("timeBankEdit");
        private TextBox TableTimeBankIncrem => TextBox("timeBankAutoincrementEdit");
        #endregion
        #region Buttons
        private Button SaveButton => Button("saveButton");
        private Button CloseButton => Button("closeButton");
#endregion

        public void CreateTable (
            //General Settings
            string T_name, /*string T_tags,*/ string T_currency, /*string T_Game,*/ string T_LS, string T_HS, string T_ante, string T_BIMin, string T_BIMax, 
            string T_Seats, string T_Cap, string T_Rake, string T_Straddle, 
            string T_TableMin, string T_TableMax, string T_FreeSeats,
            string T_BBJ, bool T_Anonym, bool T_RIT, bool T_DP,
            string T_Pass, string T_UAC, string T_Reconnect, string T_Chat,
            string T_ActTime, string T_TimeBank, string T_TBInc)
        {
            TableName.Click();   TableName.Text = T_name;
            //TableTags.SelectedItemText = T_tags;
            TableCurrency.Click(); Selectvalue(T_currency).Click();
            /*TableGameType.Click();
            Selectvalue(T_Game).Click();*/
            StakesLow.Click();   StakesLow.SetValue(T_LS);
            StakesHigh.Click();  StakesHigh.SetValue(T_HS);
          //  TableAnte.Click();   TableAnte.SetValue(T_ante);
            BuyInMin.Click();    BuyInMin.SetValue(T_BIMin);
            BuyInMax.Click();    BuyInMax.SetValue(T_BIMax); 
            TableSeats.Click();  Selectvalue(T_Seats).Click();
         //   TableCap.Click();    TableCap.Text = T_Cap;
            TableRake.Click();   Selectvalue(T_Rake).Click();
            TableStraddle.Click(); Selectvalue(T_Straddle).Click();
            TableMin.Click();    TableMin.Text = T_TableMin;
            TableMax.Click();    TableMax.Text = T_TableMax;
           // TableFreeSeats.Click();  TableFreeSeats.Text = T_FreeSeats;
            TableBBJ.Click();     Selectvalue(T_BBJ).Click();
            if (T_Anonym == true) { AnonymTable.Select(); } else { AnonymTable.UnSelect(); }
            if (T_RIT == true) { RITTable.Select(); } else { RITTable.UnSelect(); }
            if (T_DP == true) { TableDP.Select(); } else { TableDP.UnSelect(); }
            TablePassword.Click(); TablePassword.Text = T_Pass;
            TableUACRule.Click(); Selectvalue(T_UAC).Click();
            TableReconnectRule.Click(); Selectvalue(T_Reconnect).Click();
            TableChatRule.Click(); Selectvalue(T_Chat).Click();
          /*  TableActionTimeout.Click(); TableActionTimeout.Text = T_ActTime;
            TableTimeBankAmount.Click(); TableTimeBankAmount.Text = T_TimeBank;
            TableTimeBankIncrem.Click(); TableTimeBankIncrem.Text = T_TBInc;*/
            Playback.Wait(2000);
            SaveButton.Click();
        }
       
    }
       
}
