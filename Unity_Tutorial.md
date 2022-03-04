# Basic Settings

## 1. unity 설치

#### 1.0 unity 가입하세요.

#### 1.1 unity hub 설치  

https://store.unity.com/download?ref=personal  

#### 1.2 unity version 2019.3.12f1 설치

unity 같은 프로젝트여도 버전에 따라 빌드가 실패되기도 합니다. 하나의 프로젝트를 완성하기 전까지 모두가 동일 버전을 유지한다고 보면 됩니다.  
따라서 버전 확인은 매우 중요!  
unity hub > 설치 > 추가 > Unity 다운로드 아카이브 > 해당 버전 Unity Hub으로 다운(브라우저: unityhub://2019.3.12f1/84b23722532d)  
안드로이드 SDK를 반드시 포함해야 한다.


#### 1.3 기본 unity 설명

- **Scene**: Scene은 게임 화면 플로우 설계의 기본 단위입니다. android의 activity라고 생각하면 될 것 같아요. game menu scene, game play scene 이런 식입니다.
  - 시점 확대 축소: 마우스 스크롤
  - 시점 이동: option+cmd+마우스
  - 시점 회전: option+마우스
  - q,w,e,r 로 scene 내의 object를 편집할 방법을 선택할 수 있습니다. (각각 시점이동, object xyz이동, object xyz회전, object xyz 확대축소)

- **Game**: camera에 의해서 사용자에게 실제로 보여지게 될 화면입니다.
  - 위의 재생 버튼으로 Game 시작. 다시 누르면 정지. 옆은 일시정지
- **GameObject**: Scene 안에 존재하는 것들의 기본 단위는 GameObject입니다. 지금 상황에서는 눈에 보이는 게 다 gameobject라고 볼 수 있습니다. gameobject 간에는 parent-child 관계를 가지기도 합니다.
- **Hierarchy**: Scene에 존재하는 모든 Gameobject들을 보여줍니다. 그들간의 parent-child 관계를 보여줍니다.
- **Project**: project directory 안에서 unity가 import해온 것들을 보여줍니다. asset store에서 import하거나 unity project 창에 명시적으로 드래그 앤 드롭하여 import할 수 있습니다.  
  project안에 있는 요소들을 실제로 사용하려면 scene(hierarchy)으로 끌어올려야 합니다.
- **Inspector**: GameObject의 하위 속성은 Component입니다. Component를 추가하여 GameObject가 어떤 특징을 갖게 해줍니다.
  - [Transform(가장 많이 보게 됨)](https://docs.unity3d.com/2019.3/Documentation/ScriptReference/Transform.html)은 모든 GameObject가 기본적으로 가지는 속성입니다. Position, Rotation, Scale 등의 속성을 가집니다. 다양한 component가 있는데, 우리 프로젝트에서는 그리 중요치 않은 것 같습니다.
  - GameObject에 component로 C# script를 추가하여, GameObject가 생명/렌더링 주기 또는 프레임마다 원하는대로 작동하게 할 수 있습니다.  
    - script로 거의 모든 걸 할 수 있습니다. gameobject 생성, 삭제, transform 변경 등 ex. 매 프레임마다 x축으로 1씩 이동
    - 기본 scripting 관련은 'Basic API' chapter에서 진행

- 제 화면 구성입니다.

![unity screenshot](https://user-images.githubusercontent.com/29906076/88801756-1ba90880-d1e5-11ea-8169-ce8963f4ce64.png)



## 2. vs code 연동

#### 2.1 vs code 설치

#### 2.2 라이브러리와 플러그인 설치

[VS Code 설치 및 Unity 연동](https://ijemin.com/blog/%EC%9C%A0%EB%8B%88%ED%8B%B0%EC%97%90-%EB%B9%84%EC%A3%BC%EC%96%BC-%EC%8A%A4%ED%8A%9C%EB%94%94%EC%98%A4-%EC%BD%94%EB%93%9C-visual-studio-code-vscode-%EC%97%B0%EB%8F%99%EB%B0%A9%EB%B2%95/)  

#### 2.3 vs code에서의 unity 디버깅

[유니티 VSCode 디버깅 방법](https://thd0011.tistory.com/49)  

- asset store 단축키는 cmd + 9  
- 저는 아래와 같이 설정해서 쓰고 있어요.
- launch file이 있어야 vscode에서 debugging을 돌릴 수 있음.
- c# library 참조파일을 파일을 unity에서 생성해줘서 vscode에서 library 코드 참조를 할 수 있는데, 사라진 경우 Write workspace settings과 install Unity Debugger 중 하나를 누르면 다시 생김 (뭔지 확인하고 추후 업데이트할게요) 
  ![unity debugging settings](https://user-images.githubusercontent.com/29906076/88800049-78ef8a80-d1e2-11ea-94ab-457d730e7318.png)
- vscode 화면.
- Assembly-CSharp*.csproj 이 생성되었고, gameobject 등 여러 unity에 필요한 class와 함수 정의를 vscode에서 바로 볼 수 있다.
  ![vscode screenshot](https://user-images.githubusercontent.com/29906076/88800659-78a3bf00-d1e3-11ea-9acd-515967603f62.png)  
  ![vscode screenshot2](https://user-images.githubusercontent.com/29906076/88800922-db955600-d1e3-11ea-9f70-f9205a222fce.png)

#### 2.+a vs code 단축키가 익숙하지 않다면

IntelliJ IDEA Keybindings plugin이 있어요. (intellij가 아마 안드로이드 스튜디오, PyCharm 등이랑 동일할듯..? 같은 jetbrains 계열)


# Basic API

## 0. 기본 개념

## 1. unity scripting

scripting API document: https://docs.unity3d.com/2019.3/Documentation/ScriptReference/  
버전에 따라 내용이 다를 수 있기 때문에 2019.3의 내용인지 확인하고 진행한다.  
검색하다보면 구버전이지만 한국어로 된 Reference가 있어서 종종 보기도 합니다. (대략적인 개념 파악 용도로만. 실제 사용을 위한 것은 버전 확인 필수)  

#### 1.0 basic concept

unity gameobject에 c# script를 연결하면,  
Monobehavior 인터페이스를 구현하는 클래스가 자동으로 생성되고, 거기에는 Start()와 Update() 두 함수가 있다.  

- Start(): 게임 시작 시 실행  
- Update(): 매 프레임마다 실행  
- 아래는 예시
  - Start에서 object의 초기 위치를 지정한다.
  - Update에서 y축 기준으로 매 프레임마다 10도씩 회전한다. 더불어서 현재 y값으로 위아래 중 이동방향을 결정하고, 해당 방향으로 position을 이동한다.
  - object는 회오리처럼 회전하면서 위아래로 이동하게 된다.
- script가 연결된 GameObject의 transform은 아래처럼 변수 설정 없이 바로 참조가 가능하다.

```
    using System.Collections;
    using System.Collections.Generic;
    using System;
    using UnityEngine;
    
    public class Rotate : MonoBehaviour {
    
        public bool moveUpward = false;
        public float movingSpeed = 6f;
        
        // Start is called before the first frame update
        void Start()
        {
            transform.position = new Vector3(5,0,0);
            
        }

        // Update is called once per frame
        void Update()
        {
            transform.RotateAround(new Vector3(0,0,0), Vector3.up, 10);
            if (transform.position.y >= 10) {
                moveUpward = false;
            } else if (transform.position.y <= 0) {
                moveUpward = true;
            }
            transform.position = new Vector3(transform.position.x, transform.position.y + movingSpeed * Time.deltaTime * (-1 + 2 * Convert.ToInt16(moveUpward)), transform.position.z);
        }
    }
```

#### 1.1 자주 보는 클래스

1. [Transform](https://docs.unity3d.com/2019.3/Documentation/ScriptReference/Transform.html)
   - Transform에는 (global)position과 localPosition 두종류의 것이 있는데. global은 전체 scene 기준, local은 부모의 transform을 기준으로 한다.
     - ex. 부모가 global기준 3,2,0 에 있고 자식이 local position 1,0,0에 있으면  자식은 global 기준으로는 4,2,0에 존재한다.
     - ex. 얼굴에 고정되는 effect는 얼굴 object의 0,0,0에 두면 얼굴 object 움직임에 따라서 알아서 같이 움직이게 된다.
2. [Vector3](https://docs.unity3d.com/2019.3/Documentation/ScriptReference/Vector3.html)
   - Transform.position은 Vector3 클래스로 그 값을 가지고 있다.
   - unity 안에서의 모든 위치는 vector로 계산한다. vector와 관련된 함수들이 실제로 응용된다.
     - ex. 어깨와 팔 지점을 관통하는 축을 얻고자 하면 어깨.position - 팔.position을 하면 된다.
   - 유사한 역할을 하는 클래스로 [Quarternion](https://docs.unity3d.com/2019.3/Documentation/ScriptReference/Quaternion.html)이 있으며, 회전에 대한 계산을 담당한다.
3. [GameObject](https://docs.unity3d.com/2019.3/Documentation/ScriptReference/GameObject.html)
   - GameObject.Instantiate나 Destroy로 생성 또는 제거할 수 있다.
   - Inspector 창에서 보여지는 모든 Component들이 다 GameObject.GetComponet로 접근이 가능하다.
   - Transform은 그냥 gameObject.transform으로 접근하면 된다.

#### 1.2 인스턴스 필드

아래와 같이 script class 내에서 public으로 선언된 인스턴스 변수들은 Unity Inspector에서 확인할 수 있는 것들이다.  
false, 6f같은 값을 넣어줄 수도 있고, 다른 gameobject를 드래그앤 드롭으로 지정할 수도 있다.  
만약 효과 이펙트가 두 object를 가로지르는 축을 기준으로 회전하게 하고 싶다면 참조하고 싶은 두 object를 필드에 지정하고 gameObject1.transform 같이 해당 object의 위치를 참조할 수 있다.    

```
    public class Rotate : MonoBehaviour {
    
        public bool moveUpward = false;
        public float movingSpeed = 6f;
        public GameObject gameObject1;
        
        // Start is called before the first frame update
        void Start()
        {
            transform.position = new Vector3(5,0,0);
            
        }

        // Update is called once per frame
        void Update()
        {
        ...
```

아래는 sprial moving이라는 script에 public 변수들이 설정된 화면  
두개의 motion particle을 기준으로 sprial effect라는 game object가 잔상을 남기면서 이동하고 있다.
![instance field example](https://user-images.githubusercontent.com/29906076/88808644-1c926800-d1ee-11ea-998b-d5f9e207c54d.png)

#### 1.3 안드로이드/iOS에서의 unity 함수 호출

unity 프로젝트를 OS에 맞게 AAR, JAR 등등으로 export하고, 안드로이드에서 library 처럼 사용할 수 있다.  
가장 기본적인 명령 구조는  
UnityPlayer.UnitySendMessage("GameObject 이름", "연결된 script에 정의된 함수 이름", 함수에전달할파라미터)  
우리 프로젝트에 적용시켜보면 아래와 같은 방식으로 구현될 것 같다.  

**Android**

```
UnityPlayer.UnitySendMessage("FrameManager", "LoadFrame", 11);  
UnityPlayer.UnitySendMessage("EffectSelector", "Attach", {touchedPosition, effectId, frameRange});  
```

**Unity**

```
public class ScriptForEffectSelector : MonoBehaviour {
    
        public EffectRepository effectRepository;
        public EffectManager effectManager;
        
        void Start() {   
        }
        
        void Update() {
        }
        
        public void Attach(AttachRequest request) {
            Effect effect = effectRepository.findById(request.effectId);
            Person person = calculateClosestPerson(effect.getBodyPositionCategory(), request.touchedPosition);
            effectManager.applyEffect(person, effect, request.frameRange);
        }
        ...
```

