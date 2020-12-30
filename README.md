# README

**感谢阅读！！！**

---

### 游戏背景

##### 1.1 游戏梗概

​		这是一款跑酷游戏，玩家控制游戏主角收集燃料，躲避NPC车辆，摆脱警车追捕，到达目的地，游戏胜利。

##### 1.2游戏类型

​		角色扮演，玩家在游戏里扮演一辆小汽车，躲避NPC车和警车，在城市街道里“逃跑”。

##### 1.3 游戏操作

​		键盘**WASD**操纵主角汽车移动，鼠标点击界面按钮互动。

### 游戏功能

##### 2.1 包含的元素

- 玩家

  1. 单例模式

  2. 记录历史关卡收集“捡”到的燃料数量
  3. 到达目的地（小地图里的绿点），游戏胜利

- NPC车
  1. 动态加载自动寻路组件
  2. 定点寻路
  3. 设计模式，表达和功能分开编写，工厂模式

- 警车
  1. 状态模式
  2. 当玩家进入追捕距离，警车切换追捕状态
  3. 当玩家距离警车较远时，警车是巡逻模式
- 燃料
  1. 随机位置生成
  2. 碰撞消失
  3. 触发玩家身上的音效

- UI
  1. 小地图 展示城市全貌，玩家的实时位置，目的地的位置，不展示燃料的位置
  2. 燃料剩余进度条 字面意思，若燃料剩余量为0时，玩家速度speed变为0，既玩家停止不动。
- 音频
  1. 玩家与燃料相撞时，发出碰撞音效
  2. 游戏开始、游戏运行、游戏结算，不同场景不同音效

- 弹窗
  1. 历史记录 可以展示历史游戏获取的燃料数量
  2. 设置 背景音乐大小、音效的开关
  3. 游戏结束弹窗，展示游戏结束，退出按钮和历史按钮

### 缺陷

- 历史记录的数据库还没做出来
- 燃料进度条功能没有实现
- 游戏暂停结束功能没有实现

### 迭代期望

- 玩家Player与NPC发生碰撞，会有油量掉落（或者模拟实物掉落）

- 音量，全局控制
- 当燃料的剩余量>0.8时，加速技能生成，键盘**Q**键启动加速技能，技能冷却3秒。
- 当燃料的剩余量<0.3时，UI进度条变成红色。