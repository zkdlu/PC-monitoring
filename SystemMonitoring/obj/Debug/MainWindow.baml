   M S B A M L   `   `   `  ����K  GSystemMonitoring, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SystemMonitoringSystemMonitoring  5   	   ?$clr-namespace:SystemMonitoring.ViewsSystemMonitoring.Views  66   !    SystemMonitoring.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:SystemMonitoring     5   	   6views$clr-namespace:SystemMonitoring.Views     66   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  6i   b ^GalaSoft.MvvmLight.Platform, Version=5.4.1.0, Culture=neutral, PublicKeyToken=5f873c45e98af8a1.command http://www.galasoft.ch/mvvmlight  6�     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	       �� Source�� 5
   
   $ resources/styles.xaml?�6   %    .��5      � .+�5   
   %   SystemMonitoring.Views.BaseView   
  CardUI#��[  6   ��69   �� *	CardWidth+��6U   �� *
CardHeight+)   #SystemMonitoring.Views.CpuUsageView  5   
   #��[  6   ��6=   �� *	CardWidth+��6Y   �� *
CardHeight+.   (SystemMonitoring.Views.DiskReadWriteView  5   
   #��[  6"   ��6B   �� *	CardWidth+��6^   �� *
CardHeight+*   $SystemMonitoring.Views.DiskUsageView  5   
   #��[  6   ��6>   �� *	CardWidth+��6Z   �� *
CardHeight+5      5      