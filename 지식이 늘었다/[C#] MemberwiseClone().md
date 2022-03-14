# 
> #### 기존에는 이런 느낌이었는데   
> ```C#
> switch(Condition)
> {
> 	case 1:
> 		Info = clsBaseDatas.Info1;
> 		break;
> 	case 2:
> 		Info = clsBaseDatas.Info2;
> 		break;
> 	case 3:
> 		Info = clsBaseDatas.Info3;
> 		break;
> }
> PLC.SendAck(true);
> FTP.Upload(Info);
> ```   

# 
> #### 이번 프로젝트에서는 객체를 하나가 아닌 4개씩 처리하게 되었다.   
> ```C#
> for(int i = 0; i < 4; i++)
> {
> 	switch(Condition)
> 	{
> 		case 1:
> 			Info[i] = clsBaseDatas.Info1[i];
> 			break;
> 		case 2:
> 			Info[i] = clsBaseDatas.Info2[i];
> 			break;
> 		case 3:
> 			Info[i] = clsBaseDatas.Info3[i];
> 			break;
> 	}
> }
> PLC.SendAck(true);
> for(int i = 0; i < 4; i++)
> 	FTP.Upload(Info[i]);
> ```
> 빈 정보가 업로드되는 상황이 발생했고   
> 로그 상으로 확인하니 분명 정보가 존재 했었지만 사라지는 현상이었다.     
### 나는 이걸 몰랐다.
## 이미 생성된 객체는 다른 공간에 넣을 때 참조만이 복사된다. (Shallow Copy)

##### 우리 PLC는 프로그램으로부터 정보처리 완료 신호를 받고나서 기동하고   
##### 프로그램은 R영역을 계속 트래킹하는데, FTP 업로드가 완료되기 전에 정보가 지워졌다.      
##### 프로퍼티가 많아서 생성자로 일일이 넣어주기는 귀찮았고 검색해보니 좋은게 있었다.   
```C#
object object.MemberwiseClone()
```
##### 저런식으로 적용할 예정이다.   
```C#
public Info
{
	String Property1 { get; set; }
	String Property2 { get; set; }
	int Property3 { get; set; }
	...
	public Info GetClone()
	{
		return (Info)this.MemberwiseClone();
	}
}
```
