   M S B A M L   `   `   `  ����E  AFreeToGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:FreeToGame.ViewModelFreeToGame.ViewModel  5           FreeToGame.View.DetailPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      8	viewmodel"clr-namespace:FreeToGame.ViewModel     5        N� Title$  Detail Page��5       N� 
Background
 ��  � � DataContext 5      '   !FreeToGame.ViewModel.DetailPageVM  5	   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $	��200��69   $	��200��6E   $��20q�6R   $	��Top=�6^   ��6   �� *CurrentGame.Thumbnail+6^   �� 5   
   $��1��6   $��20q�6%   
���  ��.+�5      �� $��24(�6;   $
��Bold"�6I   $��0,0,0,10q�6[   ��6   �� *CurrentGame.Title+6[   �� 5      $
��Wrap=�6A   $��0,0,0,10q�6U   ��6   �� *CurrentGame.Description+6U   �� 5      $��Genre:��6   $
��Bold"�6&   �� 5      $��0,0,0,10q�6;   ��6   �� *CurrentGame.Genre+6;   �� 5       $��	Platform:��6   $
��Bold"�6)   �� 5!      $��0,0,0,10q�6>   ��6   �� *CurrentGame.Platform+6>   5"      5#      5$      