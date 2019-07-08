# LCL_UI -WinForm常用窗体库
@[toc]
## 前言
在做桌面应用程序的开发过程中，发现经常需要做文本输入、选择、判断等操作，每次遇到都在窗体上画控件写事件太过麻烦，于是想到写一套常用到的窗体库，也为以后在遇到节省了时间。

## 功能列表
项目刚开始，于是我也就需要用到什么就写什么功能，以后遇到的多了慢慢会积累起来的，目前分三部分：

 - 窗体
 	- 提示框
 		- 消息提示框
 		- 选择提示框(Yes/No)
 		- 文本输入框
 		- 密码输入框
 		- 列表选择框(多选/单选)
 	- 消息框
 		- Toast(仿Android Toast消息框) 
 - 组件
 	- 支持窗体跟随鼠标拖拽的组件(具体作用见上一篇文章)
 - 控件
 	- 关闭按钮

## 快速使用
### MsgBox 消息提示框
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190708145037908.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L2xnajEyM3hq,size_16,color_FFFFFF,t_70)
**方法原型**
```csharp
/// <summary>
/// 消息框
/// </summary>
/// <param name="title">标题</param>
/// <param name="content">详细内容</param>
/// <param name="buttonNames">按钮名称</param>
/// <returns></returns>
public static BoxResult<bool> MsgBox(string title, string content = default, string buttonName = null)
```
**示例**
```csharp
DialogBoxes.MsgBox("标题栏", "详细内容写在这里", "知道啦");
```

### PromptBox 选择提示栏
![在这里插入图片描述](https://img-blog.csdnimg.cn/2019070814525361.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L2xnajEyM3hq,size_16,color_FFFFFF,t_70)
**方法原型**
```csharp
/// <summary>
/// 提示框(选择True或False)
/// </summary>
/// <param name="title">标题</param>
/// <param name="content">详细内容</param>
/// <param name="buttonNames">按钮名称</param>
/// <returns></returns>
public static BoxResult<bool> PromptBox(string title, string content = default, string[] buttonNames = null)
```
**示例**
```csharp
// 调用窗体，并在窗体关闭后获取操作结果
var result = DialogBoxes.PromptBox("标题栏", "详细内容写在这里", new string[] { "同意", "残忍拒绝" });

// 这里可以使用MsgBox将结果显示出来（True或False）
DialogBoxes.MsgBox("操作结果", $"你的选择结果是：{result.Data.ToString()}");
```

### InputBox 文本输入框
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190708150032439.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L2xnajEyM3hq,size_16,color_FFFFFF,t_70)
**方法原型**
```csharp
/// <summary>
/// 输入框
/// </summary>
/// <param name="title">标题</param>
/// <param name="content">详细内容</param>
/// <param name="buttonNames">按钮名称</param>
/// <param name="handler">数据格式检查委托</param>
/// <returns></returns>
public static BoxResult<string> InputBox(string title,string content = default,string[] buttonNames = null, InputBox.CheckFormatHandler handler = null)
```
**示例**
```csharp
// 调用窗体，并在窗体关闭后获取操作结果
var result = DialogBoxes.InputBox("标题栏", "详细内容写在这里", null, null);

// 这里可以使用MsgBox将结果显示出来（如果是关闭输入框取消了输入可以另做提示）
if (!result.IsCancel)
{
	DialogBoxes.MsgBox(tbTitle.Text, $"刚才输入的内容是：{result.Data}", "好的");
}
else
{
	DialogBoxes.MsgBox(tbTitle.Text, "您取消了输入。", "知道啦");
}
```

### PasswordBox 密码输入框
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190708150920832.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L2xnajEyM3hq,size_16,color_FFFFFF,t_70)
**方法原型**
```csharp
/// <summary>
/// 密码框
/// </summary>
/// <param name="title">标题</param>
/// <param name="content">详细内容</param>
/// <param name="buttonNames">按钮名称</param>
/// <param name="handler">数据格式检查委托</param>
/// <returns></returns>
public static BoxResult<string> PasswordBox(string title, string content = default, string[] buttonNames = null, PasswordBox.CheckFormatHandler handler = null)
```
**示例**
```csharp
// 调用窗体，并在窗体关闭后获取操作结果
// 通过传入的lambda表达式检查输入内容格式正确性，如果lambda表达式返回false，则窗体震动。
// 这里的lambda表达式功能是检查密码长度是否达到6位长度
var result = DialogBoxes.PasswordBox(tbTitle.Text, tbContent.Text, new string[] { "确定", "取消", "清除" },(psw) => { return psw.Length >= 6; });

// 这里可以使用MsgBox将结果显示出来（如果是关闭输入框取消了输入可以另做提示）
if (!result.IsCancel)
{
	DialogBoxes.MsgBox(tbTitle.Text, $"刚才输入的密码是：{result.Data}", "好的");
}
else
{
	DialogBoxes.MsgBox(tbTitle.Text, "您取消了密码输入。", "知道啦");
}
```

### SelectBox 选择列表框
**方法原型**
```csharp
/// <summary>
/// 选择框
/// </summary>
/// <param name="title">标题</param>
/// <param name="content">详细内容</param>
/// <param name="items">选项集合</param>
/// <param name="allowMultiSelection">是否可多选</param>
/// <param name="buttonNames">按钮名称</param>
/// <param name="handler">数据格式检查委托</param>
/// <returns></returns>
public static BoxResult<List<string>> SelectBox(string title, string content = default, ICollection items = null,bool allowMultiSelection = false, string[] buttonNames = null, SelectBox.CheckFormatHandler handler = null)
```

#### 单选模式
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190708151857475.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L2xnajEyM3hq,size_16,color_FFFFFF,t_70)
**示例**
```csharp
// 调用窗体，并在窗体关闭后获取操作结果
// 通过传入的lambda表达式检查输入内容格式正确性，如果lambda表达式返回false，则窗体震动。
// 这里的lambda表达式功能是检查是否至少选择了一项
var result = DialogBoxes.SelectBox(tbTitle.Text, tbContent.Text, new string[] { "土豆", "洋葱", "西红柿", "玉米" }, false, new string[] { "确定", "取消", "全选", "反选" },(items) => { return items.Count > 0; });

// 这里可以使用MsgBox将结果显示出来
if (!result.IsCancel)
{
	DialogBoxes.MsgBox(tbTitle.Text, $"刚才勾选的项目是：{result.Data[0]}", "好的");
}
else
{
	DialogBoxes.MsgBox(tbTitle.Text, "您取消了选择。", "知道啦");
}
```

#### 多选模式
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190708151908989.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L2xnajEyM3hq,size_16,color_FFFFFF,t_70)
**方法原型**
```csharp
/// <summary>
/// 选择框
/// </summary>
/// <param name="title">标题</param>
/// <param name="content">详细内容</param>
/// <param name="items">选项集合</param>
/// <param name="allowMultiSelection">是否可多选</param>
/// <param name="buttonNames">按钮名称</param>
/// <param name="handler">数据格式检查委托</param>
/// <returns></returns>
public static BoxResult<List<string>> SelectBox(string title, string content = default, ICollection items = null,bool allowMultiSelection = false, string[] buttonNames = null, SelectBox.CheckFormatHandler handler = null)
```

**示例**
```csharp
// 调用窗体，并在窗体关闭后获取操作结果
var result = DialogBoxes.SelectBox(tbTitle.Text, tbContent.Text,new string[] { "土豆","洋葱","西红柿","玉米"},true,new string[]{ "确定","取消","全选","反选"}, null);

// 这里可以使用MsgBox将结果显示出来
if (!result.IsCancel)
{
	StringBuilder sb = new StringBuilder();
	foreach (string s in result.Data) sb.Append(s+" ");
	DialogBoxes.MsgBox(tbTitle.Text, $"刚才勾选的项目是：{sb}", "好的");
}
else
{
	DialogBoxes.MsgBox(tbTitle.Text, "您取消了选择。", "知道啦");
}
```

### Toast 消息提示框
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190708153350496.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L2xnajEyM3hq,size_16,color_FFFFFF,t_70)
**方法原型**
```csharp
/// <summary>
/// 显示消息提示
/// </summary>
/// <param name="content">消息内容</param>
/// <param name="delay">消息提示时长</param>
/// <param name="context">当前处于焦点的控件</param>
public static void Show(string content,int delay = 2000, Control context = null)
```

**示例**
```csharp
// 调用窗体，并在窗体关闭后获取操作结果
Toast.Show("Toast中的信息", 2000, this);
```

## 获取Demo程序&DLL文件&源码
下载 DLL&Demo程序: https://github.com/landriesnidis/LCL_UI/releases/latest
源代码 Github: https://github.com/landriesnidis/LCL_UI