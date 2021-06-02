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

namespace GitTests.Actions
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SelectProduct recording.
    /// </summary>
    [TestModule("0ed5a501-2f0c-478d-b193-0621b4ec532d", ModuleType.Recording, 1)]
    public partial class SelectProduct : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::GitTests.GitTestsRepository repository.
        /// </summary>
        public static global::GitTests.GitTestsRepository repo = global::GitTests.GitTestsRepository.Instance;

        static SelectProduct instance = new SelectProduct();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectProduct()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelectProduct Instance
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

            // ===== Navigation =====
            Report.Log(ReportLevel.Info, "Section", "===== Navigation =====", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.Content.lnk_MacBook'", repo.ApplicationUnderTest.Content.lnk_MacBookInfo, new ActionTimeout(30000), new RecordItemIndex(1));
            repo.ApplicationUnderTest.Content.lnk_MacBookInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(2));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Content.lnk_MacBook' at 22;12.", repo.ApplicationUnderTest.Content.lnk_MacBookInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Content.lnk_MacBook.Click("22;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='$602.00') on item 'ApplicationUnderTest.Content.lbl_Precio'.", repo.ApplicationUnderTest.Content.lbl_PrecioInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.ApplicationUnderTest.Content.lbl_PrecioInfo, "InnerText", "$602.00");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
