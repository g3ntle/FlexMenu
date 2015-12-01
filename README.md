# FlexMenu

## Overview

* [Features](#features)
* [Usage](#usage)
    * [FlexMenu](#flexmenu)
    * [FlexHeader](#flexheader)

## Features

* Flexible *Menu* & *Header*
* Binding support
* Fully animated

## Usage

Add a reference to the `FlexMenu` assembly and add the *XML namespace* below to your `Window`.

```xaml
<Window x:Class="MyProject.MyWindow"
        ...
        xmlns:fm="clr-namespace:FlexMenu.Controls;assembly=FlexMenu"
        Title="MyProject" Height="300" Width="300">
```

### FlexMenu

The *FlexMenu* is a simple vertical menu which supports one or more *FlexMenuItem*s as its content. 

A *FlexMenuItem* is a simpel Model with two Properties.

* **Text:** String *(Text to render)*
* **Icon:** ImageSource (*Icon to render*)

```xaml
<fm:FlexMenu>
    <fm:FlexMenuItem Text="One" Icon="{StaticResource MyImage1}"/>
    <fm:FlexMenuItem Text="Two" Icon="{StaticResource MyImage2}"/>
    <fm:FlexMenuItem Text="Three" Icon="{StaticResource MyImage3}"/>
</fm:FlexMenu>
```

![FlexMenu](Media/FlexMenu.png)

### FlexHeader

The *FlexHeader* is a simple horizontal header split in two sections: *Title* and *Subtitle*. The width of these sections can be set individually, as well as the background color. The *Title* section also features an *Icon* which is based off an *ImageSource*.

```xaml
<fm:FlexHeader Icon="{StaticResource MyImage}"
               Title="Hello" Subtitle="World"
               TitleWidth="1*" SubtitleWidth="2*"
               TitleBackground="DarkGreen" SubtitleBackground="Green" />
```

![FlexMenu](Media/FlexHeader.png)
