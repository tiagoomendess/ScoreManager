   M S B A M L   `   `   `  ����I  EScoreManagerPL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ScoreManagerPLScoreManagerPL  5   	       ScoreManagerPL.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ScoreManagerPL     5   	     � 
ResizeMode$  CanMinimize=�5   	    � Icon$ icon.ico��5	   	    � Title$ Score Manager��5
   	   $	��600��6   $	��400��6,   .��5      �  � ColumnDefinitions 5   
   .+�5   
    � -   5          �Name$ frame��5      $�� ��6   $
��Left=�6*   $	��561��6E   $	��Top=�6R   $	��394��6j   �� 5   
   ���	#FFF4F4F5$
��Left=�6%   $	��143��6@   $��	10,36,0,0q�6M   
���   �$	��Top=�6o   $	��361��6�   �� 5   
   -   5         ��Name$ textBoxVisitado��5      $
��Left=�6+   $��23��6F   $��	22,71,0,0q�6R    �� TextWrapping$
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��120��6�   6�   �� 5   
   -   5         ��Name$ labelVisitado��5      $��Visitado��6'   $
��Left=�6:   $��	22,45,0,0q�6U   $	��Top=�6h   �� 5   
   -   5        $ textBoxVisitante��5      $
��Left=�6,   $��23��6G   $��
22,128,0,0q�6S   $
 Wrap=�6g   $�� ��6{   $	��Top=�6�   $	��120��6�   6�   �� 5   
   -   5        $ labelVisitante��5      $��	Visitante��6(   $
��Left=�6<   $��
22,102,0,0q�6W   $	��Top=�6k   �� 5   
   -   5         ��Name$ maisGoloFora��5      $��+��6'   $
��Left=�63   $��175,128,0,0q�6N   $	��Top=�6c   $��23��6{   $��23��6�   6�   �� 5   
   -   5        $ menosGoloFora��5      $��-��6(   $
��Left=�64   $��203,128,0,0q�6O   $	��Top=�6d   $��23��6|   $��23��6�   6�   �� 5   
   -   5        $ resultadoFora��5      $
��Left=�6)   $��23��6D   $��147,128,0,0q�6P   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $��23��6�   6�   �� 5   
   -	   5        $ maisGoloCasa��5      $��+��6'   $
��Left=�63   $��
175,71,0,0q�6N   $	��Top=�6b   $��23��6z   $��23��6�   6�   �� 5   
   -
   5        $ menosGoloCasa��5      $��-��6(   $
��Left=�64   $��
203,71,0,0q�6O   $	��Top=�6c   $��23��6{   $��23��6�   6�   �� 5   
   -   5        $ resultadoCasa��5      $
��Left=�6)   $��23��6D   $��
147,71,0,0q�6P   $
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $��23��6�   6�   �� 5   
   ���	#FFF4F4F5$
��Left=�6%   $	��143��6@   $��
10,191,0,0q�6M   
���   �$	��Top=�6p   $	��361��6�   �� 5   
   -   5        	 ��Name$	 cronometroOutput��5      $
��Left=�6.   $��14(�6I   $��162,210,0,0q�6W   $
��Wrap=�6l   $��
Cronometro��6�   $	��Top=�6�   $��94��6�   �� 5   
   -   5        $ cronometroIniciar��5      $��Iniciar��6,   $
��Left=�6>   $��
28,241,0,0q�6Y   $	��Top=�6m   $��75��6�   6�   �� 5    
   -   5        $ cronometroParar��5       $��Parar��6*   $
��Left=�6:   $��112,241,0,0q�6U   $	��Top=�6j   $��75��6�   �� 5!   
   -   5        $ cronometroRestart��5!      $��	Reiniciar��6,   $
��Left=�6@   $��197,241,0,0q�6[   $	��Top=�6p   $��75��6�   �� 5"   
   -   5        $ cronometroReset��5"      $��Limpar��6*   $
��Left=�6;   $��283,241,0,0q�6V   $	��Top=�6k   $��75��6�   5#      5$      