   M S B A M L   `   `   `  ????O  KClient_BLCHxVote_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Client_BLCHxVote_WPFClient_BLCHxVote_WPF  5      Q-clr-namespace:Client_BLCHxVote_WPF.ViewModelsClient_BLCHxVote_WPF.ViewModels  6G   1    +Client_BLCHxVote_WPF.Views.VotingResultView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QScottPlot.WPF, Version=4.1.59.0, Culture=neutral, PublicKeyToken=e53b06131e34a3aae aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Cclient_blchxvote_wpf"clr-namespace:Client_BLCHxVote_WPF     5      D
viewmodels-clr-namespace:Client_BLCHxVote_WPF.ViewModels     6G     N? Title$  VotingResultView??5
      .??5      ? .+?5   
   ?? ???#4F6C77$??60??5      $??60??5      $	??Top=?5      .+?5      ?? -   5        $??	VoteTitle??5      $??Nunito-VariableFont_wght)?5      $??32(?5      $??Normal$?5      $
??Bold"?5      
???????$??Center=?5      $??0,10,0,0q?5      $??
xVOTE 2022??5      $??Center=?5      5      ?? 5   
   $??0 70 0 0q?5      .+?5      ?? $	??170??5       $??\Assets\NodesPNG.png??5!      ?? 5#      -   5        $??
OnlyWinner??5.      $??Center=?5$      $??Bottom=?5%      $??Nunito-VariableFont_wght)?5&      $??32(?5'      $??Normal$?5(      $??Regular"?5)      
???   ? ?? TextAlignment$ Center=?5+      $
??Wrap=?5,      $??0 20 0 0q?5-      ??5/      ?? *
SoloWinner+&   System.Windows.Controls.DataGrid  51      -   5        $??Candidatess??55      $??2 20 2 0q?53         AutoGenerateColumns$ False??54      
?????? $??Center=?57         AreRowDetailsFrozen$
 True??58         RowBackground
 ????    SelectionMode$ Single=?5:         CanUserSortColumns$ False??5;         CanUserAddRows$ False??5<         CanUserDeleteRows$ False??5=      	   CanUserResizeRows$	 False??5>      
   CanUserReorderColumns$
 False??5?         
IsReadOnly$
 True??5@      "   VerticalScrollBarVisibility$
 Auto=?5A         RowHeaderWidth$ 0Q?5B      ??52      ?? *BalanceView+   Columns 5C      0  *System.Windows.Controls.DataGridTextColumn  5D      ,  &System.Windows.Controls.DataGridColumn   Header$ Кандидат??5E         
FontFamily$ Nunito-VariableFont_wght)?5G         FontSize$ 18Q?5H         Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5I      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5F      ?? *CandidateName+   HeaderStyle 5J      ?? 5K       ?? 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6$   .?5L   "   ??  ?? Property ? ?? ?? Value$ 18(?6=   ?? 5M   "    ? ??$ Medium"?6?   ?? 5N   "    ? ??$ Stretch=?6H   ?? 5O   "    ? ??
 ???? 6?   ?? 5P   "    ? ??
 ?????6?   ?? 5Q   "    ? ??$ Nunito-VariableFont_wght)?6?   ?? 5R   "    ? ?? ?#4F6C776?   5S         	CellStyle 5U      ?? 5V      *  $System.Windows.Controls.DataGridCell"  6$   .?5W   "   ??  ? ??$ Center=?6M   5X      5Z        5[      $ Процент??5\      $ Nunito-VariableFont_wght)?5^      $ 18Q?5_       5]      ?? *	Balance+ 5`      ?? 5a      "  6$   .?5b   "   ??  ? ??$ 18(?6=   ?? 5c   "    ? ??$ Medium"?6?   ?? 5d   "    ? ??$ 31??6>   ?? 5e   "    ? ??
 ?????6?   ?? 5f   "    ? ?? ?#4F6C776?   ?? 5g   "    ? ??$ Nunito-VariableFont_wght)?6?   5h       5j      ?? 5k      "  6$   .?5l   "   ??  ? ??$ Center=?6M   5m      5o      5q      5r      5s      5t      