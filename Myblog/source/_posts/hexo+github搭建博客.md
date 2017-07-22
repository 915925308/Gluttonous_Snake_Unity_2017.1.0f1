---
title: github+hexo搭建博客
date: 7/18/2017 8:54:46 PM
tag: github
---

<h1>使用github+hexo搭建blog</h1>
<h5>技术点没有怎么解释，仅供自己参考，有想参考我的看不懂的，联系我。</h5>
><font color=#228B22 size=5 face="楷体">1:安装git</font>

<font size = 4><https://git-scm.com/downloads></font>
<font size = 4>除了选择要安装的目录，其他的一路下一步</font>

<!-- more -->

><font color=#228B22 size=5 face="楷体">2:安装Node.js</font>

<font size = 4><http://nodejs.cn/download/></br></font>
<font size = 4>同上</font>

><font color=#228B22 size=5 face="楷体">3:申请github账号，本机配置github仓库</font>

<font size = 4>github官网：<https://github.com></br></font>
<font size = 4>新建仓库，如果你要搭建blog那么名字就必须是<font color=red>你的github名字.github.io</font>下面是我的参考</font>
![](http://i.imgur.com/hkDuNDI.png)
####本机配置github仓库：</font>
+ 生成SSH密钥Git Bash中输入<code>ssh-keygen -t rsa</code>
![](http://i.imgur.com/G9EGvxf.png)
+ 找到文件id_rsa.pub把里面的内容输入到github的SSH中进行本机绑定
![](http://i.imgur.com/lBjyc5O.png)
![](http://i.imgur.com/PXsLlvh.png)
+ 进行用户名和邮箱的绑定
![](http://i.imgur.com/AvrLNl1.png)
+ 检查SSH设置成功<code>ssh -T git@github.com</code>
![](http://i.imgur.com/rDGS8vh.png)

><font color=#228B22 size=5 face="楷体">4:安装Hexo</font>

<font size = 4>Git Bash中输入:<font size=4><code>npm install -g hexo</code></font></font>
<font size = 4>有可能会被墙拦截，可以下载[蓝灯](https://github.com/getlantern/forum/issues/833)进行翻墙</font>

><font color=#228B22 size=5 face="楷体">5:初始化Hexo</font>
<font size = 4>在你想要**<font color=red>创建的文件夹下运行Git Bash</font>**输入代码：<font size = 4><code>Hexo init</code></font></font>
![](http://i.imgur.com/qSRvsWV.png)

><font color=#229B22 size=5 face="楷体">6:配置文件_config.yml</font>
![](http://i.imgur.com/r8BCC8G.png)
![](http://i.imgur.com/jS2YhSU.png)
<font size = 4>第二个一定要配置上，因为这指向你的github仓库地址,在配置的时候一定要注意<font color=red  size=4 face="楷体">每个属性前面有空格</font></font>
<font size = 4>在我其他电脑上测试的时候发现repo不能用https，那么我们可以试一下SSH，如果这个地方出错将会导致我们上传到github不能上传成功</font>
![](http://i.imgur.com/3oIcL3Q.png)
![](http://i.imgur.com/qZTvjxd.png)

><font color=#228B22 size=5 face="楷体">7:安装hexo-deployer-git自动部署发布工具</font>
<font size = 4>在Git Bash中输入<code>npm install hexo-deployer-git  --save</code></font>
![](http://i.imgur.com/w8OgS5B.png)

><font color=#228B22 size=5 face="楷体">8:发布到GitHub</font>
<font size = 4>在Git Bash中输入<code>hexo clean && hexo g && hexo d</code>首次输入会让你输入Github账号和密码</font>

><font color=#228B22 size=5 face="楷体">9:绑定域名</font>
<font size = 4>我们不绑定域名也是可以用的，只需要输入我们的项目名字在地址栏就能够访问。</font>
<font size = 4>下面讲绑定域名：</font>
+ 在阿里云买一个域名，新手的话建议在阿里云买，因为腾讯云的域名需要备案，不备案的话解析不能成功，通过下面的我们就把我们的域名指向我们的项目名子了。
![](http://i.imgur.com/uJ22DLQ.png)
![](http://i.imgur.com/6o4hmgd.png)