﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace GitTests
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("8049f51c-ade8-46a2-8ec1-d6dd502546e1", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the GitTestsRepository repository.
        /// </summary>
        public static GitTestsRepository repo = GitTestsRepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.lbl_YourStore'", repo.ApplicationUnderTest.lbl_YourStoreInfo, new ActionTimeout(30000), new RecordItemIndex(0));
            repo.ApplicationUnderTest.lbl_YourStoreInfo.WaitForExists(30000);
            
            // ===== Set Currency =====
            Report.Log(ReportLevel.Info, "Section", "===== Set Currency =====", new RecordItemIndex(1));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.cbo_Currency' at 40;11.", repo.ApplicationUnderTest.cbo_CurrencyInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.cbo_Currency.Click("40;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.btn_USDollar' at 31;10.", repo.ApplicationUnderTest.btn_USDollarInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.btn_USDollar.Click("31;10");
            Delay.Milliseconds(200);
            
            // ===== Navigation =====
            Report.Log(ReportLevel.Info, "Section", "===== Navigation =====", new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Content.lnk_MacBook' at 22;12.", repo.ApplicationUnderTest.Content.lnk_MacBookInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.Content.lnk_MacBook.Click("22;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='$602.00') on item 'ApplicationUnderTest.Content.lbl_Precio'.", repo.ApplicationUnderTest.Content.lbl_PrecioInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.ApplicationUnderTest.Content.lbl_PrecioInfo, "InnerText", "$602.00");
            Delay.Milliseconds(100);
            
            // ===== Add 2 Cart =====
            Report.Log(ReportLevel.Info, "Section", "===== Add 2 Cart =====", new RecordItemIndex(7));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.btn_Cart' at 134;25.", repo.ApplicationUnderTest.btn_CartInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.btn_Cart.Click("134;25");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>'Success: You have added  to your !') on item 'ApplicationUnderTest.msg_SuccessAdded'.", repo.ApplicationUnderTest.msg_SuccessAddedInfo, new RecordItemIndex(9));
            Validate.AttributeContains(repo.ApplicationUnderTest.msg_SuccessAddedInfo, "InnerText", "Success: You have added  to your !");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.lnk_Checkout' at Center.", repo.ApplicationUnderTest.lnk_CheckoutInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.lnk_Checkout.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.lnk_Checkout'", repo.ApplicationUnderTest.lnk_CheckoutInfo, new ActionTimeout(30000), new RecordItemIndex(11));
            repo.ApplicationUnderTest.lnk_CheckoutInfo.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
