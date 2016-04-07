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
    using uFrame.Kernel;
    using uFrame.MVVM;
    using uFrame.MVVM.Bindings;
    using uFrame.Serialization;
    using yigame.epoker;
    
    
    public class PlayerPositionsVCBase : uFrame.MVVM.ViewComponent {
        
        public virtual CoreGameRootViewModel CoreGameRoot {
            get {
                return (CoreGameRootViewModel)this.View.ViewModelObject;
            }
        }
        
        public virtual void ExecuteRefreshCoreGame() {
            CoreGameRoot.RefreshCoreGame.OnNext(new RefreshCoreGameCommand() { Sender = CoreGameRoot });
        }
        
        public virtual void ExecuteRootMatchBegan() {
            CoreGameRoot.RootMatchBegan.OnNext(new RootMatchBeganCommand() { Sender = CoreGameRoot });
        }
        
        public virtual void ExecuteQuitCoreGame() {
            CoreGameRoot.QuitCoreGame.OnNext(new QuitCoreGameCommand() { Sender = CoreGameRoot });
        }
        
        public virtual void ExecutePlayerJoin() {
            CoreGameRoot.PlayerJoin.OnNext(new PlayerJoinCommand() { Sender = CoreGameRoot });
        }
        
        public virtual void ExecutePlayerLeave() {
            CoreGameRoot.PlayerLeave.OnNext(new PlayerLeaveCommand() { Sender = CoreGameRoot });
        }
        
        public virtual void ExecuteCalcPosIdAndRepos() {
            CoreGameRoot.CalcPosIdAndRepos.OnNext(new CalcPosIdAndReposCommand() { Sender = CoreGameRoot });
        }
        
        public virtual void ExecuteTurnNext() {
            CoreGameRoot.TurnNext.OnNext(new TurnNextCommand() { Sender = CoreGameRoot });
        }
        
        public virtual void ExecuteRootMatchOver() {
            CoreGameRoot.RootMatchOver.OnNext(new RootMatchOverCommand() { Sender = CoreGameRoot });
        }
        
        public virtual void ExecuteRefreshCoreGame(RefreshCoreGameCommand command) {
            command.Sender = CoreGameRoot;
            CoreGameRoot.RefreshCoreGame.OnNext(command);
        }
        
        public virtual void ExecuteRootMatchBegan(RootMatchBeganCommand command) {
            command.Sender = CoreGameRoot;
            CoreGameRoot.RootMatchBegan.OnNext(command);
        }
        
        public virtual void ExecuteQuitCoreGame(QuitCoreGameCommand command) {
            command.Sender = CoreGameRoot;
            CoreGameRoot.QuitCoreGame.OnNext(command);
        }
        
        public virtual void ExecutePlayerJoin(PlayerJoinCommand command) {
            command.Sender = CoreGameRoot;
            CoreGameRoot.PlayerJoin.OnNext(command);
        }
        
        public virtual void ExecutePlayerLeave(PlayerLeaveCommand command) {
            command.Sender = CoreGameRoot;
            CoreGameRoot.PlayerLeave.OnNext(command);
        }
        
        public virtual void ExecuteCalcPosIdAndRepos(CalcPosIdAndReposCommand command) {
            command.Sender = CoreGameRoot;
            CoreGameRoot.CalcPosIdAndRepos.OnNext(command);
        }
        
        public virtual void ExecuteTurnNext(TurnNextCommand command) {
            command.Sender = CoreGameRoot;
            CoreGameRoot.TurnNext.OnNext(command);
        }
        
        public virtual void ExecuteRootMatchOver(RootMatchOverCommand command) {
            command.Sender = CoreGameRoot;
            CoreGameRoot.RootMatchOver.OnNext(command);
        }
    }
    
    public class PlayerTestToolsVCBase : uFrame.MVVM.ViewComponent {
        
        public virtual PlayerViewModel Player {
            get {
                return (PlayerViewModel)this.View.ViewModelObject;
            }
        }
        
        public virtual void ExecutePlayerReady() {
            Player.PlayerReady.OnNext(new PlayerReadyCommand() { Sender = Player });
        }
        
        public virtual void ExecutePlayerCancel() {
            Player.PlayerCancel.OnNext(new PlayerCancelCommand() { Sender = Player });
        }
        
        public virtual void ExecuteMatchBegan() {
            Player.MatchBegan.OnNext(new MatchBeganCommand() { Sender = Player });
        }
        
        public virtual void ExecuteBeganToPlay() {
            Player.BeganToPlay.OnNext(new BeganToPlayCommand() { Sender = Player });
        }
        
        public virtual void ExecuteBeganToWait() {
            Player.BeganToWait.OnNext(new BeganToWaitCommand() { Sender = Player });
        }
        
        public virtual void ExecuteTurnOn() {
            Player.TurnOn.OnNext(new TurnOnCommand() { Sender = Player });
        }
        
        public virtual void ExecuteTurnOff() {
            Player.TurnOff.OnNext(new TurnOffCommand() { Sender = Player });
        }
        
        public virtual void ExecuteWin() {
            Player.Win.OnNext(new WinCommand() { Sender = Player });
        }
        
        public virtual void ExecuteOver() {
            Player.Over.OnNext(new OverCommand() { Sender = Player });
        }
        
        public virtual void ExecuteInitOK() {
            Player.InitOK.OnNext(new InitOKCommand() { Sender = Player });
        }
        
        public virtual void ExecuteRefreshPlayer() {
            Player.RefreshPlayer.OnNext(new RefreshPlayerCommand() { Sender = Player });
        }
        
        public virtual void ExecuteButtonReadyClicked() {
            Player.ButtonReadyClicked.OnNext(new ButtonReadyClickedCommand() { Sender = Player });
        }
        
        public virtual void ExecuteButtonStartClicked() {
            Player.ButtonStartClicked.OnNext(new ButtonStartClickedCommand() { Sender = Player });
        }
        
        public virtual void ExecuteLogInfo() {
            Player.LogInfo.OnNext(new LogInfoCommand() { Sender = Player });
        }
        
        public virtual void ExecuteReorder() {
            Player.Reorder.OnNext(new ReorderCommand() { Sender = Player });
        }
        
        public virtual void ExecuteButtonPassClicked() {
            Player.ButtonPassClicked.OnNext(new ButtonPassClickedCommand() { Sender = Player });
        }
        
        public virtual void ExecuteButtonDealClicked() {
            Player.ButtonDealClicked.OnNext(new ButtonDealClickedCommand() { Sender = Player });
        }
        
        public virtual void ExecuteButtonTurnNext() {
            Player.ButtonTurnNext.OnNext(new ButtonTurnNextCommand() { Sender = Player });
        }
        
        public virtual void ExecuteShowCardsToPile() {
            Player.ShowCardsToPile.OnNext(new ShowCardsToPileCommand() { Sender = Player });
        }
        
        public virtual void ExecutePlayerReady(PlayerReadyCommand command) {
            command.Sender = Player;
            Player.PlayerReady.OnNext(command);
        }
        
        public virtual void ExecutePlayerCancel(PlayerCancelCommand command) {
            command.Sender = Player;
            Player.PlayerCancel.OnNext(command);
        }
        
        public virtual void ExecuteMatchBegan(MatchBeganCommand command) {
            command.Sender = Player;
            Player.MatchBegan.OnNext(command);
        }
        
        public virtual void ExecuteBeganToPlay(BeganToPlayCommand command) {
            command.Sender = Player;
            Player.BeganToPlay.OnNext(command);
        }
        
        public virtual void ExecuteBeganToWait(BeganToWaitCommand command) {
            command.Sender = Player;
            Player.BeganToWait.OnNext(command);
        }
        
        public virtual void ExecuteTurnOn(TurnOnCommand command) {
            command.Sender = Player;
            Player.TurnOn.OnNext(command);
        }
        
        public virtual void ExecuteTurnOff(TurnOffCommand command) {
            command.Sender = Player;
            Player.TurnOff.OnNext(command);
        }
        
        public virtual void ExecuteWin(WinCommand command) {
            command.Sender = Player;
            Player.Win.OnNext(command);
        }
        
        public virtual void ExecuteOver(OverCommand command) {
            command.Sender = Player;
            Player.Over.OnNext(command);
        }
        
        public virtual void ExecuteInitOK(InitOKCommand command) {
            command.Sender = Player;
            Player.InitOK.OnNext(command);
        }
        
        public virtual void ExecuteRefreshPlayer(RefreshPlayerCommand command) {
            command.Sender = Player;
            Player.RefreshPlayer.OnNext(command);
        }
        
        public virtual void ExecuteButtonReadyClicked(ButtonReadyClickedCommand command) {
            command.Sender = Player;
            Player.ButtonReadyClicked.OnNext(command);
        }
        
        public virtual void ExecuteButtonStartClicked(ButtonStartClickedCommand command) {
            command.Sender = Player;
            Player.ButtonStartClicked.OnNext(command);
        }
        
        public virtual void ExecuteLogInfo(LogInfoCommand command) {
            command.Sender = Player;
            Player.LogInfo.OnNext(command);
        }
        
        public virtual void ExecuteAddCards(AddCardsCommand command) {
            command.Sender = Player;
            Player.AddCards.OnNext(command);
        }
        
        public virtual void ExecuteRemoveCards(RemoveCardsCommand command) {
            command.Sender = Player;
            Player.RemoveCards.OnNext(command);
        }
        
        public virtual void ExecuteReorder(ReorderCommand command) {
            command.Sender = Player;
            Player.Reorder.OnNext(command);
        }
        
        public virtual void ExecuteButtonPassClicked(ButtonPassClickedCommand command) {
            command.Sender = Player;
            Player.ButtonPassClicked.OnNext(command);
        }
        
        public virtual void ExecuteButtonDealClicked(ButtonDealClickedCommand command) {
            command.Sender = Player;
            Player.ButtonDealClicked.OnNext(command);
        }
        
        public virtual void ExecuteButtonTurnNext(ButtonTurnNextCommand command) {
            command.Sender = Player;
            Player.ButtonTurnNext.OnNext(command);
        }
        
        public virtual void ExecuteShowCardsToPile(ShowCardsToPileCommand command) {
            command.Sender = Player;
            Player.ShowCardsToPile.OnNext(command);
        }
    }
    
    public class CardTouchVCBase : uFrame.MVVM.ViewComponent {
        
        public virtual CardViewModel Card {
            get {
                return (CardViewModel)this.View.ViewModelObject;
            }
        }
        
        public virtual void ExecuteSelectCard() {
            Card.SelectCard.OnNext(new SelectCardCommand() { Sender = Card });
        }
        
        public virtual void ExecuteDeselectCard() {
            Card.DeselectCard.OnNext(new DeselectCardCommand() { Sender = Card });
        }
        
        public virtual void ExecuteSelectCard(SelectCardCommand command) {
            command.Sender = Card;
            Card.SelectCard.OnNext(command);
        }
        
        public virtual void ExecuteDeselectCard(DeselectCardCommand command) {
            command.Sender = Card;
            Card.DeselectCard.OnNext(command);
        }
    }
    
    public class CardShadowVCBase : uFrame.MVVM.ViewComponent {
        
        public virtual CardViewModel Card {
            get {
                return (CardViewModel)this.View.ViewModelObject;
            }
        }
        
        public virtual void ExecuteSelectCard() {
            Card.SelectCard.OnNext(new SelectCardCommand() { Sender = Card });
        }
        
        public virtual void ExecuteDeselectCard() {
            Card.DeselectCard.OnNext(new DeselectCardCommand() { Sender = Card });
        }
        
        public virtual void ExecuteSelectCard(SelectCardCommand command) {
            command.Sender = Card;
            Card.SelectCard.OnNext(command);
        }
        
        public virtual void ExecuteDeselectCard(DeselectCardCommand command) {
            command.Sender = Card;
            Card.DeselectCard.OnNext(command);
        }
    }
}
