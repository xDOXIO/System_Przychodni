   M S B A M L   `   `   `  ����I  EPrzychodniaGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PrzychodniaGUIPrzychodniaGUI  5   	   #    PrzychodniaGUI.OknoUmowWizyte   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:PrzychodniaGUI     5   	     � Title$  OknoUmowWizyte��5   	   $	��720��6    $	��900��6-   .��5	      � .+�5
   
   �� -   5         ��Name$ lbImie��5
      $��Imie pacjenta��6    $
��Left=�68   $��41��6S   $��	10,10,0,0q�6_   $	��Top=�6r   $	��217��6�   $��18(�6�   �� 5   
   -   5        $ 
lbNazwisko��5      $��Nazwisko pacjenta��6$   $
��Left=�6@   $��41��6[   $��	10,75,0,0q�6g   $	��Top=�6z   $	��217��6�    J� RenderTransformOrigin$ 0.679,-0.083&�6�   $��18(�6�   �� 5   
   -   5        $ lbData��5      $'��!Data i godzina (yyyy/mm/dd HH:mm)��6    $��41��6L   $��
10,142,0,0q�6X   $	��Top=�6l   $	��307��6�   $ 0.679,-0.083&�6�   $��18(�6�   $
��Left=�6�    � UseLayoutRounding .  6�   �� 5   
   -   5        $ lbLekarz��5      $��Lekarz��6"   $
��Left=�63   $��41��6N   $��
10,215,0,0q�6Z   $	��Top=�6n   $	��217��6�   $ 0.679,-0.083&�6�   $��18(�6�   �� 5   
   -   5        $ lbUsluga��5      $��Usługa��6"   $��Right=�63   $��41��6O   $��0,465,666.6,0q�6[   $	��Top=�6r   $	��217��6�   $ 0.679,-0.083&�6�   $��18(�6�   �� 5   
   -   5         ��Name$ txtImie��5      $
��Left=�6#   $��41��6>   $��
332,10,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��513��6�   $��18(�6�   �� 5   
   -   5        $ txtNazwisko��5      $
��Left=�6'   $��41��6B   $��
332,75,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��513��6�   $��18(�6�   �� 5   
   -   5        $ txtData��5      $
��Left=�6#   $��41��6>   $��332,142,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��513��6�   $��18(�6�   �� 5   
   -	   5         ��Name$ 
lstLekarze��5      $
��Left=�6&   $	��218��6A   $��332,215,0,0q�6N   $	��Top=�6c   $	��513��6{   $��18(�6�   �� 5   
   -
   5        $ 	lstUslugi��5      $
��Left=�6%   $	��190��6@   $��332,465,0,0q�6M   $	��Top=�6b   $	��513��6z   $��18(�6�   �� 5   
   -   5         ��Name$ btUmow��5      $��Umow wizyte��6!   $
��Left=�67   $��38��6R   $��
10,549,0,0q�6^   $	��Top=�6r   $	��134��6�   $��18(�6�   6�   �� 5   
   -   5        $ btAnuluj��5      $��Anuluj��6#   $
��Left=�64   $��38��6O   $��
10,617,0,0q�6[   $	��Top=�6o   $	��134��6�   $��18(�6�   6�   5      5      