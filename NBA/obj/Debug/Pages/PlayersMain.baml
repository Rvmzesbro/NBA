   M S B A M L   `   `   `  ����>  :NBA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:NBA.Pages	NBA.Pages  5          NBA.Pages.PlayersMain   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:NBA.Pages     5        N� Title$  PlayersMain��5	      .��5      � $��Center=�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5   
   �� .+�5      �� $��0��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��/Resources/logo.jpg��6   $��20��5      �� 5      $��NBA Management System��6    $��15(�5      $��	10 15 0 0q�5      �� 5      $��Players Main��6    $��20(�5      $��SemiBold"�5      $��
100 10 0 0q�5      �� 5      $��50��6   $��20��5       �� CornerRadius$ 3��5       
�������$��1q�5"      $��	300 0 0 0q�5#      ._�5$      �� -   5         ��Name$ BTBack��5$   !   $��50��5%      $��20��5&      
�������.��5)      �� $
��Back��6(   $��0 -3 4 0q�5*   !   5+      5,      5-      �� 5.      
���   �$	��0.5q�5/      $��0 5 0 30q�50      51      �� 53      $��1��6   .+�54      �� $��50��6   ���#6995c2._�56      �� .+�58      �� -   5         ��Name$ SPFilterButtons��59   %   $ 
Horizontal=�58   %   .+�5;      �� ���#6995c2���#6995c2$	��All��5=   '   5?      �� 5A      $ 
Horizontal=�6%   .+�5C      �� $��Season:��6(   $��0 0 5 0q�5D   (   �� 5E      -   5         ��Name$ CBSeason��5E   '   $	��100��5F   '   $��20��5G   '   5I      �� 5K      $��Team:��6(   $��30 0 5 0q�5L   (   �� 5M      -   5        $ CBTeam��5M   '   $	��100��5N   '   $��20��5O   '   5Q      �� 5S      $��Playername:��6(   $��30 0 5 0q�5T   (   �� 5U      -   5         ��Name$ TBSearchName��5U   &   $	��100��5V   &   $��20��5W   &   $
��Name��5X   &   5Z   &   5[      5\      5_      5`      �� 5b      $��1��6   .+�5c      &   System.Windows.Controls.DataGrid  -   5          Name$ 	DGPlayers��5c      	   Columns	 5f      0  *System.Windows.Controls.DataGridTextColumn  5g        5h      ,  &System.Windows.Controls.DataGridColumn
   Header$	
 No.��6-     5i      $

 Name��6-     5j      $

 Team��6-     5k      $
 Position��6-     5l      $
 Weight��6-     5m      $
 Height��6-     5n      $
 
Experience��6-     5o      $
 Country��6-   5q      �� 5r      $��fsdfdsf��6   5s      5w      �� 5x   
   $��2��6   ���#6995c2$��20��5z      $��Bottom=�5{      ._�5|      �� $T��NThe current season is 2016-2017, and the NBA already has a history of 71 years��6   $��Center=�5}      $��Center=�5~      5      5�      5�      