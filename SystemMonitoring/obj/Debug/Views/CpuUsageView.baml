   M S B A M L   `   `   `  ����K  GSystemMonitoring, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:SystemMonitoring.ViewsSystemMonitoring.Views  5      I)clr-namespace:SystemMonitoring.ViewModelsSystemMonitoring.ViewModels  6A   )    #SystemMonitoring.Views.CpuUsageView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:SystemMonitoring.Views     5      @
viewmodels)clr-namespace:SystemMonitoring.ViewModels     6A     � DataContext  5	      3   -SystemMonitoring.ViewModels.CpuUsageViewModel  5
   
   .��5      � .+�5   
   (�  (� Stretch$ Uniform=�6   $��10q�6$   .��5      �� $��Center=�6   .+�5      �  � ColumnDefinitions 5      �� 5      $��* �6+   �� 5      $��3* �6+   .+�5      �� $��0��6    $��Usage: ��60   $��Center=�6?   $
��Bold"�6\   �� 5      $��1��6!    �� Orientation$ 
Horizontal=�61   .+�5      �� $
��Left=�6e   ��6$   ��  �� Path$ Usage� �� UpdateSourceTrigger$ PropertyChanged=�6e   �� 5      $��%��6$   5      5      � 5       5      �� 5      $��* �6+   �� 5      $��3* �6+   .+�5      �� $��0��6    $��Free: ��60   $��Center=�6>   $
��Bold"�6[   �� 5       $��1��6!   $ 
Horizontal=�61   .+�5!      �� $
��Left=�6d   ��6$   �� $
 Free�$ PropertyChanged=�6d   �� 5"      $��%��6$   5#      5$      5%      5&      5'      5(      