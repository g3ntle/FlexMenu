# FlexMenu

## Overview

* [Usage](#usage)
    * [FlexMenu](#flexmenu)
    * [FlexHeader](#flexheader)

## Usage

Add the following XML namespace to your code:

```xaml
xmlns:fm="clr-namespace:FlexMenu.Controls;assembly=FlexMenu"
```

### FlexMenu

```xaml
<fm:FlexMenu>
    <fm:FlexMenuItem Text="Hello, world!" Icon="..."/>
    <fm:FlexMenuItem Text="Hello, world!" Icon="..."/>
    <fm:FlexMenuItem Text="Hello, world!" Icon="..."/>
</fm:FlexMenu>
```

![FlexMenu](Media/FlexMenu.png)

### FlexHeader

```xaml
<fm:FlexHeader Icon="..."
               Title="Hello" Subtitle="World"
               TitleWidth="1*" SubtitleWidth="2*"/>
```

![FlexMenu](Media/FlexHeader.png)
