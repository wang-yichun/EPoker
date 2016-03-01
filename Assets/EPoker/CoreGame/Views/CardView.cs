namespace yigame.epoker {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.Kernel;
    using uFrame.MVVM;
    using uFrame.MVVM.Services;
    using uFrame.MVVM.Bindings;
    using uFrame.Serialization;
    using UniRx;
    using UnityEngine;
    
    
    public class CardView : CardViewBase {
        
        protected override void InitializeViewModel(uFrame.MVVM.ViewModel model) {
            base.InitializeViewModel(model);
            // NOTE: this method is only invoked if the 'Initialize ViewModel' is checked in the inspector.
            // var vm = model as CardViewModel;
            // This method is invoked when applying the data from the inspector to the viewmodel.  Add any view-specific customizations here.
        }
        
        public override void Bind() {
            base.Bind();
            // Use this.Card to access the viewmodel.
            // Use this method to subscribe to the view-model.
            // Any designer bindings are created in the base implementation.
        }
    
	    public override void InfoChanged(CardInfo arg1) {
			Debug.LogFormat ("InfoChanged: {0}", arg1);
	    }
    }
}
