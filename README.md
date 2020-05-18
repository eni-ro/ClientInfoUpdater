# ClientInfoUpdater
`clientinfo.xml`のaddressを更新するだけのツール  
以下のような人向けのものです
* DNSは取得しているけれど、DNS Enableが正常に動作しない  
でもIP直接指定のclientinfoだと、いざIPが変わったときに、更新したclientinfoを配信するまでに時間がかかることが予想される  
なのでユーザに自分で更新してほしい
* テスト鯖など接続先を切り替えるときに、IPなんだっけ？となり`clientinfo.xml`を書き換えるのが面倒

## 使い方
* 起動して必要な項目を入力する  
※Clientのrootフォルダに置いて使用するのを想定しています
* 一旦ツールを閉じる
* exeと同じ階層に`ClientInfoUpdater.xml`が出来ているので開く  
※項目を一つも変えないと出力されません
* 他の人に編集してもらいたくない項目の**Protectの項目を`false`から`true`に変える

## サンプル
```
<?xml version="1.0" encoding="utf-8"?>
<root>
  <ClientInfoProtect>true</ClientInfoProtect>
  <ClientInfo>.\data\clientinfo.xml</ClientInfo>
  <DNSHostProtect>true</DNSHostProtect>
  <DNSHost>mydns.co.jp</DNSHost>
  <LocalHostProtect>true</LocalHostProtect>
  <LocalHost>127.0.0.1</LocalHost>
  <IPProtect>false</IPProtect>
  <IP>192.168.11.100</IP>
  <PortProtect>true</PortProtect>
  <Port>64704</Port>
</root>
```