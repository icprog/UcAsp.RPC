# UcAsp.RPC

#服务器端配置
```XML
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <configSections>
    <sectionGroup name="service">
      <section name="server" type="System.Configuration.NameValueSectionHandler, System, Version=1.0.3300.0, Culture=neutral, PublicKeyToken=b77a5c561934e089, Custom=null" />
    </sectionGroup>
  </configSections>
  <service>
    <server>
      <add key="port" value="9966" />
      <add key="username" value="admin" />
      <add key="password" value="admin" />
    </server>
    <assmebly>
      <add key="Face" value="Face.dll" />
      <!--<add key="ISCS.WCS.Opc.Client" value="ISCS.WCS.Opc.Client.dll" />
       <add key="ISCS.WMS2.BLL" value="ISCS.WMS2.BLL.dll" />
      <add key="ISCS.WCS.BLL" value="ISCS.WCS.BLL.dll" />      
      <add key="Json" value="Newtonsoft.Json.dll" />-->
    </assmebly>
  </service>
</configuration>
```
