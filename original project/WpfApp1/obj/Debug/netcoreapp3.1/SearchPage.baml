   M S B A M L   `   `   `  ����G  CBookStoreGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:BookStoreGUIBookStoreGUI  5          BookStoreGUI.SearchPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:BookStoreGUI     5        N� Title$  Search Page��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��2* �6   .+�5   
   � $��0��6   .+�5      �� $��10q�6   ���#eee._�5      �� 
�������.+�5      �  5      �� 5      �� 5      .+�5      �� -   5         ��Name$ clearBtn��5   !   $��0��63   $��clear��6C   $��10q�6S   6_   �� 5      -   5        $ reset��5   !   $��1��60   $��Reset Search��6@   $��10q�6W   6c   5      � 5       5       �� 5!      $��1* �6/   �� 5"      $��1* �6/   �� 5#      $��1* �6/   �� 5$      $
��0.5* �6/   .+�5'      �� $��0��6$   $��Item Type: ��64   $
��Bold"�6G   	� 5)      -   5         	�Name$ BookTypeBtn��5)   &   $��2��6;   $��16��6O   $��85,0,0,0q�6[   $��Bottom=�6m   .��5*      �� $
��Book��6(   5+      	� 5,      -   5        $ JournalTypeBtn��5,   &   $��2��6>   .��5-      �� $��Journal��6(   5.      �� 50      -   5        $ 
searchType��50   H   $��15��6!   $��15��6-   $��3��68   $��serach��6\   6m   52      � 54       55      �� 56      �� 57      .+�5:      �� -   5        $��book_border��5:   !   ${�False��64   $��0��6F   $��5q�6V   ���#eee._�5;      �� .+�5<   "   �� $��Book Title:��6,   � 5=   "    5>   &   �� 5?   *   $��5* �6;   �� 5@   *   .+�5B   "   �� -   5         ��Name$ BookTitleTxtbx��5B   :   $��0��6*   $��0,0,5,0q�6R   �� 5C   &   -   5        $ titleSearch��5C   =   $��1��6-   $��search��6R   $��15��6c   $��15��6n   6z   5D   #   �� 5E   "   $��Author:��6,   � 5F   "    5G   &   �� 5H   *   $��5* �6;   �� 5I   *   .+�5K   &   �� -	   5        $ AuthorTxtbx��5K   >   $��0��6.   $��0,0,5,0q�6S   �� 5L   &   -
   5        $ authorSearch��5L   =   $��1��6-   $��search��6S   $��15��6d   $��15��6o   6{   5M   #   �� 5O   "   $��ISBN:��6,   � 5P   "    5Q   &   �� 5R   *   $��5* �6;   �� 5S   *   .+�5U   &   �� -   5        $ 	ISBNTxtbx��5U   >   $��0��6.   $��0,0,5,0q�6Q   �� 5V   &   -   5        $ 
ISBNSearch��5V   =   $��1��6-   $��search��6Q   $��15��6b   $��15��6m   6y   5W   #   �� 5X   "   $��
Publisher:��6,   �� 5Y   "   -   5        $ PublisherTxtbx��5Y   *   $��0,0,5,0q�6B   � 5Z   "    5[   &   �� 5\   *   �� 5]   *   .+�5_   &   �� $��0��60   $��	Edition: ��6@   �� 5`   &   -   5        $ EditionTxtbx��5`   .   $��1��6D   $	��5,0q�6T   5a   #   �� 5b   "   $��Published Date:��6,   (  "System.Windows.Controls.DatePicker  5c   "   -   5        $��publisherDateTxtbx��5c   -   $��0,0,5,0q�6G   �� 5d   "   $��Ganeres:��6,   �� 5e   "   -   5         ��Name$ HorrorCheck��5e   +   $��Horror��6@   �� 5f   "   -   5        $ AdvCheck��5f   +   $��	Advanture��6=   �� 5g   "   -   5        $ HistoryCheck��5g   +   $��
Historical��6A   �� 5h   "   -   5        $ BioCheck��5h   +   $��	Biography��6=   �� 5i   "   -   5        $ DetectiveCheck��5i   +   $��	Detactive��6C   �� 5j   "   -   5        $ 
SciFiCheck��5j   +   $��Science-Fiction��6?   �� 5k   "   -   5        $ 	ClasCheck��5k   +   $��Classic��6>   �� 5l   "   -   5        $ 
NovalCheck��5l   +   $��Noval��6?   5m      5n      �� 5p      -   5        $��journal_border��5p   !   ${�False��67   $��1��6I   $��5q�6Y   ���#eee._�5q      �� .+�5r   "   �� $��Journal Name:��6,   �� 5s   "   -   5        $ 
jNametxtbx��5s   *   $��0,0,5,0q�6>   �� 5t   "   $��Journal Publisher:��6,   �� 5u   "   -   5        $ jPublisherTxtbx��5u   *   $��0,0,5,0q�6C   �� 5v   "   $��Published Date:��6-     5w   "   -   5          Name$ jPDateTxtbx��5w   -   $��0,0,5,0q�6B   �� 5x   "   $��Journal Type:��6,   �� 5y   "   -   5        $ newsJTypeCheck��5y   +   $��	Newspaper��6C   �� 5z   "   -   5        $ magJTypeCheck��5z   +   $��Magazine��6B   �� 5{   "   -   5        $ perioJTypeCheck��5{   +   $��
Periodical��6D   �� 5|   "   -   5        $ comJTypeCheck��5|   +   $��Comic��6B   �� 5}   "   $��Journal Topic:��6,   �� 5~   "   -    5        $ fashJTopicCheck��5~   +   $��Fashion��6D   �� 5   "   -!   5        $ ecoJTopicCheck��5   +   $��	Economics��6C   �� 5�   "   -"   5        $ sciJTopicCheck��5�   +   $��Science��6C   �� 5�   "   -#   5        $ enteJTopicCheck��5�   +   $��Enterteinment��6D   �� 5�   "   -$   5        $ newsJTopicCheck��5�   +   $
��News��6D   �� 5�   "   -%   5        $ kidsJTopicCheck��5�   +   $
��Kids��6D   �� 5�   "   -&   5        $ proJTopicChheck��5�   +   $��Proffesional��6D   5�      5�      5�      � 5�       5�      �� 5�      �� 5�      .+�5�      �� $��0��6%   .+�5�      �� $��Prics:��6(   $��Right=�66   $��0,5,10,5q�6R   $
��Bold"�6d   �� 5�      $��	Quantity:��6(   $��Right=�69   $��0,5,10,5q�6U   $
��Bold"�6g   5�      �� 5�      $��1��6%   .+�5�      �� -'   5        $ 
PriceTxtbx��5�   &   $��50��6:   $
��Left=�6E   $
��10,5q�6`   �� 5�      -(   5        $ 
QuantTxtbx��5�   &   $��50��6:   $
��Left=�6E   $
��10,5q�6`   5�      5�      � 5�       5�      �� 5�      �� 5�      �� 5�      .+�5�      �� -)   5        $��0��5�   !   $��25��61   $��Add item��6=   6P   �� 5�      -*   5        $��1��5�   !   $��25��61   $��Remove item��6=   6S   �� 5�      $��2��6!   $��25��61   $��Add to Sale��6=   
��� �|�6S   5�      5�      5�      5�      � 5�   
   $��1��6   .+�5�      �� -+   5         ��Name$ 
myListView��5�      $
��Auto=�6+   $
��Auto=�6]    �� SelectionMode$ Single=�6�   	 �� View	 5�      �� 5�      .P�5�      �� 
 �� DisplayMemberBinding
 6)   �� *
ItemType+��5�      �� 5�   "   
 � Tag$ ItemType��67   .��6F   Item6L   5�      �� 5�      
 6)   �� *Title+��5�      �� 5�   "   $ Title��67   .��6C   
Book Title6O   5�      �� 5�      
 6)   �� *JournalName+��5�      �� 5�   "   $ JournalName��67   .��6I   Journal Name6W   5�      �� 5�      
 6)   �� *Price+��5�      �� 5�   "   $ Price��67   .��6C   Price6J   5�      �� 5�      
 6)   �� *
Quantity+��5�      �� 5�   "   $ Quantity��67   .��6F   
Quantity6P   5�      �� 5�      
 6)   �� *Author+��5�      �� 5�   "   $ Author��67   .��6D   Author6L   5�      �� 5�      
 6)   �� *	Publisher+��5�      �� 5�   "   $ 	Publisher��67   .��6G   	Publisher6R   5�      �� 5�      
 6)   �� *ISBN+��5�      �� 5�   "   $
 ISBN��67   .��6B   	Book ISBN6M   5�      �� 5�      
 6)   �� *	Edition+��5�      �� 5�   "   $ Edition��67   .��6E   Edition No.6R   5�      �� 5�      
 6)   �� *PublishDate+��5�      �� 5�   "   $ PublishedDate��67   .��6K   Book Published Date6`   5�      �� 5�      
 6)   �� *GanaresListView+��5�      �� 5�   "   $ Ganares��67   .��6E   	Ganares6N   5�      �� 5�      
 6)   �� *journalTypeListView+��5�      �� 5�   "   $ journalTypes��67   .��6J   journal Type6X   5�      �� 5�      
 6)   �� *journalTopicsListView+��5�      �� 5�   "   $ journalTopics��67   .��6K   journal Topics6[   5�      5�      5�      5      5     5     