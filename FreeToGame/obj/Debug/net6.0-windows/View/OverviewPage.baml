   M S B A M L   `   `   `  ����E  AFreeToGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FreeToGame.ViewFreeToGame.View  5      ;"clr-namespace:FreeToGame.ViewModelFreeToGame.ViewModel  5      "    FreeToGame.View.OverviewPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:FreeToGame.View     5      8	viewmodel"clr-namespace:FreeToGame.ViewModel     5        N� Title$  OverviewPage��5
       N� 
Background
 ��  � � DataContext 5      )   #FreeToGame.ViewModel.OverViewPageVM  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� ��6   �� *
GameGenres+ �� SelectedItem 66   �� *SelectedGenre+�� 5   
   $��1��6   
�������
������ $��Stretch=�6�   $��Disabled=�5      ��5   K   �� *Games+ 6i   �� *SelectedGame+��5      �� 5      .R�5      � $��Stretch=�5        5"      5#      ��5%      �� 5&      .R�5'      ��  �� Orientation$ 
Horizontal=�6!   $	��300��6:   .+�5)      �� $	��100��6=   $	��100��6J   $��4q�6V   ��6    �� *	Thumbnail+6V   �� 5+      $
��10,0q�6;   
���   �$��Center=�6\   $��11(�6w   $	��140��6�   
���  ��$��24��6�   ��6$   �� *Title+6�   5,      5-      5/      51      52      