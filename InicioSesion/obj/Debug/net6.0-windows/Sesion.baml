   M S B A M L   `   `   `  ����G  CInicioSesion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:InicioSesionInicioSesion  5          InicioSesion.Sesion   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:InicioSesion     5        N� Title$  Inicio de Sesión��5	      .��5      � $��
10,0,10,10q�6    � 	Resources 5   
      nameItemTemplate �� XPath��%L   &	        �� 5      .R�5      �� ��6   �� $ @Name��5      5      ��5   
   �� 5       �� Color$ White��6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5"   
   �� $��Usuario:��6   $��0��6#   $��0��60   $��Center=�6@   $��Center=�6[   �� 5#   
   -   5         ��Name$ 
txtUsuario��5#      $��0��6&   $��1��63   $��2��6C   $��Center=�6W   �� 5%   
   $��Contraseña:��6   $��1��6&   $��0��63   $��Center=�6C   $��Center=�6^   G� 5&   
   -   5         G�Name$ txtPswd��5&      $��1��6'   $��1��64   $��2��6D   $��Center=�6X   �� 5(   
   -   5        $��Login��5(      $��2��64   $��0��6A   $��Center=�6Q   $��Center=�6l   �� 5)   
   -   5        $��Cancelar��5)      $��2��6:   $��2��6G   $��Center=�6W   $��Center=�6r   5*      5+      