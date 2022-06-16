# Il2CppDumper

如果本项目对您造成了影响，请联系：1582421598@badguys.club

修改版本的Il2CppDumper，允许你Dump原神的UserAssembly.dll

仅支持原神2.7及以上版本

Unity il2cpp逆向工程

## 功能

* 还原DLL文件（不包含代码），可用于提取`MonoBehaviour`和`MonoScript`
* 支持ELF, ELF64, Mach-O, PE, NSO和WASM格式
* 支持Unity 5.3 - 2021.3
* 生成IDA和Ghidra的脚本，帮助IDA和Ghidra更好的分析il2cpp文件
* 生成结构体头文件
* 支持从内存dump的`libil2cpp.so`文件以绕过保护
* 支持绕过简单的PE保护

## 使用说明

直接运行Il2CppDumper.exe并依次选择il2cpp的可执行文件和global-metadata.dat文件，然后根据提示输入相应信息。

程序运行完成后将在当前运行目录下生成输出文件

### 命令行

```
Il2CppDumper.exe <executable-file> <global-metadata> <output-directory>
```

### 输出文件

#### DummyDll

文件夹，包含所有还原的DLL文件

使用[dnSpy](https://github.com/0xd4d/dnSpy)，[ILSpy](https://github.com/icsharpcode/ILSpy)或者其他.Net反编译工具即可查看具体信息

可用于提取Unity的`MonoBehaviour`和`MonoScript`，适用于[UtinyRipper](https://github.com/mafaca/UtinyRipper)或者[UABE](https://7daystodie.com/forums/showthread.php?22675-Unity-Assets-Bundle-Extractor)等

#### ida.py

用于IDA

#### ida_with_struct.py

用于IDA, 读取il2cpp.h文件并在IDA中应用结构信息

#### il2cpp.h

包含结构体的头文件

#### ghidra.py

用于Ghidra

#### Il2CppBinaryNinja

用于BinaryNinja

#### ghidra_wasm.py

用于Ghidra, 和[ghidra-wasm-plugin](https://github.com/nneonneo/ghidra-wasm-plugin)一起工作

#### script.json

用于IDA和Ghidra脚本

#### stringliteral.json

包含所有stringLiteral信息

### 关于config.json

* `DumpMethod`，`DumpField`，`DumpProperty`，`DumpAttribute`，`DumpFieldOffset`, `DumpMethodOffset`, `DumpTypeDefIndex`
  * 是否在dump.cs输出相应的内容

* `GenerateDummyDll`，`GenerateScript`
  * 是否生成这些内容

* `DummyDllAddToken`
  * 是否在DummyDll中添加token

* `RequireAnyKey`
  * 在程序结束时是否需要按键退出

* `ForceIl2CppVersion`，`ForceVersion`  
  * 当ForceIl2CppVersion为`true`时，程序将根据ForceVersion指定的版本读取il2cpp的可执行文件（Metadata仍然使用header里的版本），在部分低版本的il2cpp中可能会用到（比如安卓20版本下，你可能需要设置ForceVersion为16程序才能正常工作）

* `ForceDump`
  * 强制将文件视为dump文件

* `NoRedirectedPointer`
  * 将dump文件中的指针视为未重定向的, 从某些设备dump出的文件需要设置该项为`true`

## 常见问题

#### `Shouldn't execute to here.`

global-metadata.dat可能发生了更新，出现了不支持的情况。

#### `ERROR: It not genshin's metadata!`

global-metadata.dat可能发生了更新，文件结构出现了变化。

## 感谢

- Perfare - [Il2CppDumper](https://github.com/Perfare/Il2CppDumper)
- kagurazakasanae - [Il2CppDumper-YuanShen](https://github.com/kagurazakasanae/Il2CppDumper-YuanShen)
- djkaty - [miHoYoPlugin](https://github.com/djkaty/Il2CppInspectorPlugins/tree/master/Loaders/miHoYo)
- Unknown - [DecryptionAlgorithm](https://google.com)