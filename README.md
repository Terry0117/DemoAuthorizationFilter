# DemoAuthorizationFilter

## 設定未通過授權時要執行的動作方法
至Web.Config修改，在<system.web>標籤內新增如下方Code
```sh
	<authentication mode="Forms">
	  <forms loginUrl="~/Demo/Login"/>
	</authentication>
```
## 指定使用者通過驗證
FormsAuthentication.RedirectFromLoginPage("帳號",是否建立永久Cookie)
FormsAuthentication類別使用時須引用System.Web.Security此命名空間。