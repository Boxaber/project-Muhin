   M S B A M L   `   `   `  ����a  ]Квадратик с кнопками, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:Квадратик_с_кнопками&Квадратик_с_кнопками  5   	   0    *Квадратик_с_кнопками.zxc   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:Квадратик_с_кнопками     5   	     � Title$  Weather��5   	   $	��450��6   $	��150��6&   $	��450��62   $	��150��6B   $	��450��6Q   $	��150��6a   .��5	      � ��5
   
   �� 5       �� ImageSource$, &oblaka_nebo_zakat_118243_4752x3456.jpg��6   .+�5   
   �� -   5         ��Name$ label1��5      $�� ��6    $
��Left=�6+   $��	79,10,0,0q�6F   $	��Top=�6Y   
�������$��40��6�   �� 5   
   -   5         ��Name$ button��5      $��Узнать погоду��6"   $
��Left=�6:   $��
10,289,0,0q�6U   $	��Top=�6i   $��92��6�   6�   �� 5   
   -   5         ��Name$ textbox1��5      $
��Left=�6$   $��23��6?   $��
11,362,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��120��6�   6�   �� 5   
   -   5        $ label1_Copy��5      $��Temp:��6%   $
��Left=�65   $��	10,10,0,0q�6P   $	��Top=�6c   
�������6{   �� 5   
   -   5        $ label1_Copy1��5      $��Feels_like:��6&   $
��Left=�6<   $��	10,41,0,0q�6W   $	��Top=�6j   
�������6�   �� 5   
   -   5        $ label2��5      $�� ��6    $
��Left=�6+   $��	79,41,0,0q�6F   $	��Top=�6Y   
�������$��40��6�   �� 5   
   -   5        $ label3��5      $�� ��6    $
��Left=�6+   $��	79,72,0,0q�6F   $	��Top=�6Y   $��40��6q    J� RenderTransformOrigin$ 2.719,0.358&�6|   
�������6�   �� 5   
   -   5        $ label1_Copy4��5      $��	Temp_min:��6&   $
��Left=�6:   $��	10,72,0,0q�6U   $	��Top=�6h   $��63��6�   
�������6�   �� 5   
   -	   5        $ label1_Copy5��5      $��	Temp_max:��6&   $
��Left=�6:   $��
10,103,0,0q�6U   $	��Top=�6i   
�������6�   �� 5   
   -
   5        $ label4��5      $�� ��6    $
��Left=�6+   $��
79,103,0,0q�6F   $	��Top=�6Z   
�������$��40��6�   �� 5   
   -   5        $ label5��5      $�� ��6    $
��Left=�6+   $��
79,134,0,0q�6F   $	��Top=�6Z   
�������$��40��6�   �� 5   
   -   5        $ label1_Copy8��5      $��	pressure:��6&   $
��Left=�6:   $��
11,134,0,0q�6U   $	��Top=�6i   $��61��6�   
�������6�   �� 5   
   -   5        $ label1_Copy9��5      $��	humidity:��6&   $
��Left=�6:   $��
10,165,0,0q�6U   $	��Top=�6i   $ 	0.6,1.863&�6�   
�������6�   �� 5   
   -   5        $ label6��5      $�� ��6    $
��Left=�6+   $��
79,165,0,0q�6F   $	��Top=�6Z   
�������$��40��6�   �� 5   
   -   5        $ label1_Copy2��5      $��speed:��6&   $
��Left=�67   $��
11,196,0,0q�6R   $	��Top=�6f   $ 	0.6,1.863&�6~   
�������6�   �� 5   
   -   5        $ label7��5      $�� ��6    $
��Left=�6+   $��
79,196,0,0q�6F   $	��Top=�6Z   
�������$��40��6�   �� 5   
   -   5        $ label1_Copy3��5      $��degree:��6&   $
��Left=�68   $��
11,227,0,0q�6S   $	��Top=�6g   $ 	0.6,1.863&�6   
�������6�   �� 5   
   -   5        $ label8��5      $�� ��6    $
��Left=�6+   $��
79,227,0,0q�6F   $	��Top=�6Z   
�������$��40��6�   �� 5    
   -   5        $ label1_Copy6��5       $��country:��6&   $
��Left=�69   $��
11,258,0,0q�6T   $	��Top=�6h   $ 	0.6,1.863&�6�   
�������6�   �� 5!   
   -   5        $ label9��5!      $�� ��6    $
��Left=�6+   $��
79,258,0,0q�6F   $	��Top=�6Z   
�������$��40��6�   �� 5"   
   -   5        $��Нажми меня��5"      $
��Left=�6&   $��
11,390,0,0q�6A   $	��Top=�6U   $	��120��6m   6y   �� 5#   
   $��
Город��6   $
��Left=�6    $��
50,331,0,0q�6;   $	��Top=�6O   $��45��6g   
�������6r   5%      5&      