   M S B A M L   `   `   `  ����I  EPrzychodniaGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PrzychodniaGUIPrzychodniaGUI  5   	       PrzychodniaGUI.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:PrzychodniaGUI     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��509* �6   �� 5      $	��93* �6   �� 5      $
��190* �6   .+�5   
   �� $��Przychodnia Medicare
��6   $
��Left=�69   $��73��6T   $��
194,10,0,0q�6`   $	��Top=�6t   $	��407��6�   $
��Bold"�6�   $��36(�6�   $��2��6�   �� 5   
   $��Logowanie:
��6   $
��Left=�6/   $��45��6J   $��	51,88,0,0q�6V   $	��Top=�6i   $	��317��6�   $��24(�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ lbImie��5      $��Imię:��6    $
��Left=�60   $��50��6K   $��
51,138,0,0q�6W   $	��Top=�6k   $	��261��6�   $��20(�6�   �� 5   
   -   5        $ 
lbNazwisko��5      $��	Nazwisko:��6$   $
��Left=�68   $��50��6S   $��
51,188,0,0q�6_   $	��Top=�6s   $	��261��6�   $��20(�6�   �� 5   
   $Q��KNie jesteś jeszcze naszym pacjentem?
                   Zarejestruj się.��6   $
��Left=�6l   $��
10,138,0,0q�6�   $	��Top=�6�   $��1��6�   $��50��6�   $	��263��6�   $��15(�6�   $��2��6�   �� 5   
   $U��O                Nie jesteś z Polski?
         Zarejestruj się z kartą EKUZ.��6   $
��Left=�6o   $��
10,249,0,0q�6�   $	��Top=�6�   $��1��6�   $��54��6�   $	��263��6�   $��15(�6�   $��2��6�   �� 5   
   -   5         ��Name$ 
BtnZaloguj��5      $��Zaloguj��6%   $
��Left=�67   $	��Top=�6R   $	��168��6j   $��
68,321,0,0q�6v   $��51��6�   6�   �� 5   
   -   5        $ btnRejestracjaZagraniczna��5      $��Rejestracja Zagraniczna��64   $
��Left=�6V   $	��Top=�6q   $	��168��6�   $��
60,321,0,0q�6�   $��51��6�   $��2��6�   $��1��6�   6�   �� 5   
   -   5        $ btnZarejestruj��5      $��Zarejestruj��6)   $
��Left=�6?   $	��Top=�6Z   $	��168��6r   $��
60,193,0,0q�6~   $��51��6�   $��2��6�   $��1��6�   6�   �� 5   
   -   5         ��Name$ txtNazwisko��5      $
��Left=�6'   $��40��6B    �� TextWrapping$
 Wrap=�6N   $	��Top=�6b   $	��303��6z   $��164,193,0,0q�6�   �� 5   
   -   5        $ txtImie��5      $
��Left=�6$   $��45��6?   $��164,138,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��303��6�    J� RenderTransformOrigin$ 1.794,5.722&�6�   �� 5   
   -   5        $ btnWyjdz��5      $��Wyjdź��6#   $
��Left=�63   $��51��6N   $��288,321,0,0q�6Z   $	��Top=�6o   $	��179��6�   6�   5      5      