// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace yigame.epoker {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.MVVM;
    using uFrame.IOC;
    using uFrame.Kernel;
    using yigame.epoker;
    using UniRx;
    using uFrame.Serialization;
    
    
    public class CoreGameRootControllerBase : uFrame.MVVM.Controller {
        
        private uFrame.MVVM.IViewModelManager _CoreGameRootViewModelManager;
        
        private CoreGameRootViewModel _CoreGameRoot;
        
        [uFrame.IOC.InjectAttribute("CoreGameRoot")]
        public uFrame.MVVM.IViewModelManager CoreGameRootViewModelManager {
            get {
                return _CoreGameRootViewModelManager;
            }
            set {
                _CoreGameRootViewModelManager = value;
            }
        }
        
        [uFrame.IOC.InjectAttribute("CoreGameRoot")]
        public CoreGameRootViewModel CoreGameRoot {
            get {
                return _CoreGameRoot;
            }
            set {
                _CoreGameRoot = value;
            }
        }
        
        public IEnumerable<CoreGameRootViewModel> CoreGameRootViewModels {
            get {
                return CoreGameRootViewModelManager.OfType<CoreGameRootViewModel>();
            }
        }
        
        public override void Setup() {
            base.Setup();
            // This is called when the controller is created
        }
        
        public override void Initialize(uFrame.MVVM.ViewModel viewModel) {
            base.Initialize(viewModel);
            // This is called when a viewmodel is created
            this.InitializeCoreGameRoot(((CoreGameRootViewModel)(viewModel)));
        }
        
        public virtual CoreGameRootViewModel CreateCoreGameRoot() {
            return ((CoreGameRootViewModel)(this.Create(Guid.NewGuid().ToString())));
        }
        
        public override uFrame.MVVM.ViewModel CreateEmpty() {
            return new CoreGameRootViewModel(this.EventAggregator);
        }
        
        public virtual void InitializeCoreGameRoot(CoreGameRootViewModel viewModel) {
            // This is called when a CoreGameRootViewModel is created
            viewModel.RefreshCoreGame.Action = this.RefreshCoreGameHandler;
            viewModel.RootMatchBegan.Action = this.RootMatchBeganHandler;
            viewModel.QuitCoreGame.Action = this.QuitCoreGameHandler;
            viewModel.PlayerJoin.Action = this.PlayerJoinHandler;
            viewModel.PlayerLeave.Action = this.PlayerLeaveHandler;
            viewModel.CalcPosIdAndRepos.Action = this.CalcPosIdAndReposHandler;
            viewModel.TurnNext.Action = this.TurnNextHandler;
            viewModel.RootMatchOver.Action = this.RootMatchOverHandler;
            CoreGameRootViewModelManager.Add(viewModel);
        }
        
        public override void DisposingViewModel(uFrame.MVVM.ViewModel viewModel) {
            base.DisposingViewModel(viewModel);
            CoreGameRootViewModelManager.Remove(viewModel);
        }
        
        public virtual void RefreshCoreGame(CoreGameRootViewModel viewModel) {
        }
        
        public virtual void RootMatchBegan(CoreGameRootViewModel viewModel) {
        }
        
        public virtual void QuitCoreGame(CoreGameRootViewModel viewModel) {
        }
        
        public virtual void PlayerJoin(CoreGameRootViewModel viewModel) {
        }
        
        public virtual void PlayerLeave(CoreGameRootViewModel viewModel) {
        }
        
        public virtual void CalcPosIdAndRepos(CoreGameRootViewModel viewModel) {
        }
        
        public virtual void TurnNext(CoreGameRootViewModel viewModel) {
        }
        
        public virtual void RootMatchOver(CoreGameRootViewModel viewModel) {
        }
        
        public virtual void RefreshCoreGameHandler(RefreshCoreGameCommand command) {
            this.RefreshCoreGame(command.Sender as CoreGameRootViewModel);
        }
        
        public virtual void RootMatchBeganHandler(RootMatchBeganCommand command) {
            this.RootMatchBegan(command.Sender as CoreGameRootViewModel);
        }
        
        public virtual void QuitCoreGameHandler(QuitCoreGameCommand command) {
            this.QuitCoreGame(command.Sender as CoreGameRootViewModel);
        }
        
        public virtual void PlayerJoinHandler(PlayerJoinCommand command) {
            this.PlayerJoin(command.Sender as CoreGameRootViewModel);
        }
        
        public virtual void PlayerLeaveHandler(PlayerLeaveCommand command) {
            this.PlayerLeave(command.Sender as CoreGameRootViewModel);
        }
        
        public virtual void CalcPosIdAndReposHandler(CalcPosIdAndReposCommand command) {
            this.CalcPosIdAndRepos(command.Sender as CoreGameRootViewModel);
        }
        
        public virtual void TurnNextHandler(TurnNextCommand command) {
            this.TurnNext(command.Sender as CoreGameRootViewModel);
        }
        
        public virtual void RootMatchOverHandler(RootMatchOverCommand command) {
            this.RootMatchOver(command.Sender as CoreGameRootViewModel);
        }
    }
    
    public class BackGroundControllerBase : uFrame.MVVM.Controller {
        
        private uFrame.MVVM.IViewModelManager _BackGroundViewModelManager;
        
        private CoreGameRootViewModel _CoreGameRoot;
        
        [uFrame.IOC.InjectAttribute("BackGround")]
        public uFrame.MVVM.IViewModelManager BackGroundViewModelManager {
            get {
                return _BackGroundViewModelManager;
            }
            set {
                _BackGroundViewModelManager = value;
            }
        }
        
        [uFrame.IOC.InjectAttribute("CoreGameRoot")]
        public CoreGameRootViewModel CoreGameRoot {
            get {
                return _CoreGameRoot;
            }
            set {
                _CoreGameRoot = value;
            }
        }
        
        public IEnumerable<BackGroundViewModel> BackGroundViewModels {
            get {
                return BackGroundViewModelManager.OfType<BackGroundViewModel>();
            }
        }
        
        public override void Setup() {
            base.Setup();
            // This is called when the controller is created
        }
        
        public override void Initialize(uFrame.MVVM.ViewModel viewModel) {
            base.Initialize(viewModel);
            // This is called when a viewmodel is created
            this.InitializeBackGround(((BackGroundViewModel)(viewModel)));
        }
        
        public virtual BackGroundViewModel CreateBackGround() {
            return ((BackGroundViewModel)(this.Create(Guid.NewGuid().ToString())));
        }
        
        public override uFrame.MVVM.ViewModel CreateEmpty() {
            return new BackGroundViewModel(this.EventAggregator);
        }
        
        public virtual void InitializeBackGround(BackGroundViewModel viewModel) {
            // This is called when a BackGroundViewModel is created
            BackGroundViewModelManager.Add(viewModel);
        }
        
        public override void DisposingViewModel(uFrame.MVVM.ViewModel viewModel) {
            base.DisposingViewModel(viewModel);
            BackGroundViewModelManager.Remove(viewModel);
        }
    }
    
    public class CardControllerBase : uFrame.MVVM.Controller {
        
        private uFrame.MVVM.IViewModelManager _CardViewModelManager;
        
        private CoreGameRootViewModel _CoreGameRoot;
        
        [uFrame.IOC.InjectAttribute("Card")]
        public uFrame.MVVM.IViewModelManager CardViewModelManager {
            get {
                return _CardViewModelManager;
            }
            set {
                _CardViewModelManager = value;
            }
        }
        
        [uFrame.IOC.InjectAttribute("CoreGameRoot")]
        public CoreGameRootViewModel CoreGameRoot {
            get {
                return _CoreGameRoot;
            }
            set {
                _CoreGameRoot = value;
            }
        }
        
        public IEnumerable<CardViewModel> CardViewModels {
            get {
                return CardViewModelManager.OfType<CardViewModel>();
            }
        }
        
        public override void Setup() {
            base.Setup();
            // This is called when the controller is created
        }
        
        public override void Initialize(uFrame.MVVM.ViewModel viewModel) {
            base.Initialize(viewModel);
            // This is called when a viewmodel is created
            this.InitializeCard(((CardViewModel)(viewModel)));
        }
        
        public virtual CardViewModel CreateCard() {
            return ((CardViewModel)(this.Create(Guid.NewGuid().ToString())));
        }
        
        public override uFrame.MVVM.ViewModel CreateEmpty() {
            return new CardViewModel(this.EventAggregator);
        }
        
        public virtual void InitializeCard(CardViewModel viewModel) {
            // This is called when a CardViewModel is created
            viewModel.SelectCard.Action = this.SelectCardHandler;
            viewModel.DeselectCard.Action = this.DeselectCardHandler;
            CardViewModelManager.Add(viewModel);
        }
        
        public override void DisposingViewModel(uFrame.MVVM.ViewModel viewModel) {
            base.DisposingViewModel(viewModel);
            CardViewModelManager.Remove(viewModel);
        }
        
        public virtual void SelectCard(CardViewModel viewModel) {
        }
        
        public virtual void DeselectCard(CardViewModel viewModel) {
        }
        
        public virtual void SelectCardHandler(SelectCardCommand command) {
            this.SelectCard(command.Sender as CardViewModel);
        }
        
        public virtual void DeselectCardHandler(DeselectCardCommand command) {
            this.DeselectCard(command.Sender as CardViewModel);
        }
    }
    
    public class PlayerControllerBase : uFrame.MVVM.Controller {
        
        private uFrame.MVVM.IViewModelManager _PlayerViewModelManager;
        
        private CoreGameRootViewModel _CoreGameRoot;
        
        [uFrame.IOC.InjectAttribute("Player")]
        public uFrame.MVVM.IViewModelManager PlayerViewModelManager {
            get {
                return _PlayerViewModelManager;
            }
            set {
                _PlayerViewModelManager = value;
            }
        }
        
        [uFrame.IOC.InjectAttribute("CoreGameRoot")]
        public CoreGameRootViewModel CoreGameRoot {
            get {
                return _CoreGameRoot;
            }
            set {
                _CoreGameRoot = value;
            }
        }
        
        public IEnumerable<PlayerViewModel> PlayerViewModels {
            get {
                return PlayerViewModelManager.OfType<PlayerViewModel>();
            }
        }
        
        public override void Setup() {
            base.Setup();
            // This is called when the controller is created
        }
        
        public override void Initialize(uFrame.MVVM.ViewModel viewModel) {
            base.Initialize(viewModel);
            // This is called when a viewmodel is created
            this.InitializePlayer(((PlayerViewModel)(viewModel)));
        }
        
        public virtual PlayerViewModel CreatePlayer() {
            return ((PlayerViewModel)(this.Create(Guid.NewGuid().ToString())));
        }
        
        public override uFrame.MVVM.ViewModel CreateEmpty() {
            return new PlayerViewModel(this.EventAggregator);
        }
        
        public virtual void InitializePlayer(PlayerViewModel viewModel) {
            // This is called when a PlayerViewModel is created
            viewModel.PlayerReady.Action = this.PlayerReadyHandler;
            viewModel.PlayerCancel.Action = this.PlayerCancelHandler;
            viewModel.MatchBegan.Action = this.MatchBeganHandler;
            viewModel.BeganToPlay.Action = this.BeganToPlayHandler;
            viewModel.BeganToWait.Action = this.BeganToWaitHandler;
            viewModel.TurnOn.Action = this.TurnOnHandler;
            viewModel.TurnOff.Action = this.TurnOffHandler;
            viewModel.Win.Action = this.WinHandler;
            viewModel.Over.Action = this.OverHandler;
            viewModel.InitOK.Action = this.InitOKHandler;
            viewModel.RefreshPlayer.Action = this.RefreshPlayerHandler;
            viewModel.ButtonReadyClicked.Action = this.ButtonReadyClickedHandler;
            viewModel.ButtonStartClicked.Action = this.ButtonStartClickedHandler;
            viewModel.LogInfo.Action = this.LogInfoHandler;
            viewModel.AddCards.Action = this.AddCardsHandler;
            viewModel.RemoveCards.Action = this.RemoveCardsHandler;
            viewModel.Reorder.Action = this.ReorderHandler;
            viewModel.ButtonPassClicked.Action = this.ButtonPassClickedHandler;
            viewModel.ButtonDealClicked.Action = this.ButtonDealClickedHandler;
            viewModel.ButtonTurnNext.Action = this.ButtonTurnNextHandler;
            viewModel.ShowCardsToPile.Action = this.ShowCardsToPileHandler;
            PlayerViewModelManager.Add(viewModel);
        }
        
        public override void DisposingViewModel(uFrame.MVVM.ViewModel viewModel) {
            base.DisposingViewModel(viewModel);
            PlayerViewModelManager.Remove(viewModel);
        }
        
        public virtual void PlayerReady(PlayerViewModel viewModel) {
        }
        
        public virtual void PlayerCancel(PlayerViewModel viewModel) {
        }
        
        public virtual void MatchBegan(PlayerViewModel viewModel) {
        }
        
        public virtual void BeganToPlay(PlayerViewModel viewModel) {
        }
        
        public virtual void BeganToWait(PlayerViewModel viewModel) {
        }
        
        public virtual void TurnOn(PlayerViewModel viewModel) {
        }
        
        public virtual void TurnOff(PlayerViewModel viewModel) {
        }
        
        public virtual void Win(PlayerViewModel viewModel) {
        }
        
        public virtual void Over(PlayerViewModel viewModel) {
        }
        
        public virtual void InitOK(PlayerViewModel viewModel) {
        }
        
        public virtual void RefreshPlayer(PlayerViewModel viewModel) {
        }
        
        public virtual void ButtonReadyClicked(PlayerViewModel viewModel) {
        }
        
        public virtual void ButtonStartClicked(PlayerViewModel viewModel) {
        }
        
        public virtual void LogInfo(PlayerViewModel viewModel) {
        }
        
        public virtual void Reorder(PlayerViewModel viewModel) {
        }
        
        public virtual void ButtonPassClicked(PlayerViewModel viewModel) {
        }
        
        public virtual void ButtonDealClicked(PlayerViewModel viewModel) {
        }
        
        public virtual void ButtonTurnNext(PlayerViewModel viewModel) {
        }
        
        public virtual void ShowCardsToPile(PlayerViewModel viewModel) {
        }
        
        public virtual void PlayerReadyHandler(PlayerReadyCommand command) {
            this.PlayerReady(command.Sender as PlayerViewModel);
        }
        
        public virtual void PlayerCancelHandler(PlayerCancelCommand command) {
            this.PlayerCancel(command.Sender as PlayerViewModel);
        }
        
        public virtual void MatchBeganHandler(MatchBeganCommand command) {
            this.MatchBegan(command.Sender as PlayerViewModel);
        }
        
        public virtual void BeganToPlayHandler(BeganToPlayCommand command) {
            this.BeganToPlay(command.Sender as PlayerViewModel);
        }
        
        public virtual void BeganToWaitHandler(BeganToWaitCommand command) {
            this.BeganToWait(command.Sender as PlayerViewModel);
        }
        
        public virtual void TurnOnHandler(TurnOnCommand command) {
            this.TurnOn(command.Sender as PlayerViewModel);
        }
        
        public virtual void TurnOffHandler(TurnOffCommand command) {
            this.TurnOff(command.Sender as PlayerViewModel);
        }
        
        public virtual void WinHandler(WinCommand command) {
            this.Win(command.Sender as PlayerViewModel);
        }
        
        public virtual void OverHandler(OverCommand command) {
            this.Over(command.Sender as PlayerViewModel);
        }
        
        public virtual void InitOKHandler(InitOKCommand command) {
            this.InitOK(command.Sender as PlayerViewModel);
        }
        
        public virtual void RefreshPlayerHandler(RefreshPlayerCommand command) {
            this.RefreshPlayer(command.Sender as PlayerViewModel);
        }
        
        public virtual void ButtonReadyClickedHandler(ButtonReadyClickedCommand command) {
            this.ButtonReadyClicked(command.Sender as PlayerViewModel);
        }
        
        public virtual void ButtonStartClickedHandler(ButtonStartClickedCommand command) {
            this.ButtonStartClicked(command.Sender as PlayerViewModel);
        }
        
        public virtual void LogInfoHandler(LogInfoCommand command) {
            this.LogInfo(command.Sender as PlayerViewModel);
        }
        
        public virtual void AddCardsHandler(AddCardsCommand command) {
            this.AddCards(command.Sender as PlayerViewModel, command);
        }
        
        public virtual void RemoveCardsHandler(RemoveCardsCommand command) {
            this.RemoveCards(command.Sender as PlayerViewModel, command);
        }
        
        public virtual void ReorderHandler(ReorderCommand command) {
            this.Reorder(command.Sender as PlayerViewModel);
        }
        
        public virtual void ButtonPassClickedHandler(ButtonPassClickedCommand command) {
            this.ButtonPassClicked(command.Sender as PlayerViewModel);
        }
        
        public virtual void ButtonDealClickedHandler(ButtonDealClickedCommand command) {
            this.ButtonDealClicked(command.Sender as PlayerViewModel);
        }
        
        public virtual void ButtonTurnNextHandler(ButtonTurnNextCommand command) {
            this.ButtonTurnNext(command.Sender as PlayerViewModel);
        }
        
        public virtual void ShowCardsToPileHandler(ShowCardsToPileCommand command) {
            this.ShowCardsToPile(command.Sender as PlayerViewModel);
        }
        
        public virtual void AddCards(PlayerViewModel viewModel, AddCardsCommand arg) {
        }
        
        public virtual void RemoveCards(PlayerViewModel viewModel, RemoveCardsCommand arg) {
        }
    }
    
    public class CardsPileControllerBase : uFrame.MVVM.Controller {
        
        private uFrame.MVVM.IViewModelManager _CardsPileViewModelManager;
        
        private CoreGameRootViewModel _CoreGameRoot;
        
        [uFrame.IOC.InjectAttribute("CardsPile")]
        public uFrame.MVVM.IViewModelManager CardsPileViewModelManager {
            get {
                return _CardsPileViewModelManager;
            }
            set {
                _CardsPileViewModelManager = value;
            }
        }
        
        [uFrame.IOC.InjectAttribute("CoreGameRoot")]
        public CoreGameRootViewModel CoreGameRoot {
            get {
                return _CoreGameRoot;
            }
            set {
                _CoreGameRoot = value;
            }
        }
        
        public IEnumerable<CardsPileViewModel> CardsPileViewModels {
            get {
                return CardsPileViewModelManager.OfType<CardsPileViewModel>();
            }
        }
        
        public override void Setup() {
            base.Setup();
            // This is called when the controller is created
        }
        
        public override void Initialize(uFrame.MVVM.ViewModel viewModel) {
            base.Initialize(viewModel);
            // This is called when a viewmodel is created
            this.InitializeCardsPile(((CardsPileViewModel)(viewModel)));
        }
        
        public virtual CardsPileViewModel CreateCardsPile() {
            return ((CardsPileViewModel)(this.Create(Guid.NewGuid().ToString())));
        }
        
        public override uFrame.MVVM.ViewModel CreateEmpty() {
            return new CardsPileViewModel(this.EventAggregator);
        }
        
        public virtual void InitializeCardsPile(CardsPileViewModel viewModel) {
            // This is called when a CardsPileViewModel is created
            viewModel.PileCardsReorder.Action = this.PileCardsReorderHandler;
            CardsPileViewModelManager.Add(viewModel);
        }
        
        public override void DisposingViewModel(uFrame.MVVM.ViewModel viewModel) {
            base.DisposingViewModel(viewModel);
            CardsPileViewModelManager.Remove(viewModel);
        }
        
        public virtual void PileCardsReorder(CardsPileViewModel viewModel) {
        }
        
        public virtual void PileCardsReorderHandler(PileCardsReorderCommand command) {
            this.PileCardsReorder(command.Sender as CardsPileViewModel);
        }
    }
}
