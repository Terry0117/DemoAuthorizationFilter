# DemoAuthorizationFilter

## 設定未通過授權時要執行的動作方法
	至Web.Config修改，在<system.web>標籤內新增如下方Code
	```sh
		<authentication mode="Forms">
		  <forms loginUrl="~/Demo/Login"/>
		</authentication>
	```