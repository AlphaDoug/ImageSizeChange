   M S B A M L   `   `   `  ���� J  FImageSizeChange, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ImageSizeChangeImageSizeChange       ImageSizeChange.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:ImageSizeChange       � Title$  图片大小转化器��$	��350��$	��525��.���  � ColumnDefinitions �� $	��82* ��� $
��437* �.+��� -    ��Name$ button��$��浏览��$
��Left=�$��32��$��285.333,123,0,0q�$	��Top=�$��90��$��1���� -    ��Name$ textBox��$
��Left=�$��32��$��31.333,123,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��221��$��1���� -   $ button1��$��转换��$
��Left=�$��64��$��248.333,226,0,0q�$	��Top=�$	��165��$��1���� -    ��Name$ label��$��选择文件夹��$
��Left=�$��32��$��
26,123,0,0q�$	��Top=�$��82��$��2���� -   $ label1��$����选择一个最高级的目录之后点击转换，会自动将此目录及其所有子目录
下的所有png和tif格式的图片长宽转换成四的倍数��$
��Left=�$��50��$��	71,35,0,0q�$	��Top=�$	��395��$��2��