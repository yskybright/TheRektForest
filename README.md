# ZepDungeon
TopDown mini RPG game, assignment for Unity Bootcamp 2023.

개인과제 시연영상 ) https://youtu.be/R7hKGgXTFWA

<img src="https://github.com/yskybright/ZepDungeon/assets/148968024/3405538a-6b3f-4d95-968f-f2b3c37a508e.png" width="500" height="300"/>

<img src="https://github.com/yskybright/ZepDungeon/assets/148968024/9d5a03b4-b575-46a9-b846-f470db34e69e.png" width="500" height="300"/>


---
## ⭐ 구현 사항 (Unity 숙련_개인과제)

1. 필수요구사항 

   1-1. 필수요구사항 1 : 메인 화면 구성
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;아이디, 레벨, 골드, Status 버튼, Inventory 버튼, 던전 입장 버튼, 시계
   
   1-2. 필수요구사항 2 : Status 보기
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Status 버튼을 누르면 다른 UI 버튼은 사라지며 Status 창이 나타납니다.
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;팝업 우측 상단의 X를 누르면 Status 창이 사라지며 UI 버튼이 나타납니다.

   1-3. 필수요구사항 3 : Inventory 보기
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Inventory 버튼을 누르면 다른 UI 버튼은 사라지며 Inventory 창이 나타납니다.
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;팝업 우측 상단의 X를 누르면 Inventory 창이 사라지며 UI 버튼이 나타납니다.
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;아이템을 클릭하면 장착 여부에 따라 아이템 팝업이 나타나며 아이템을 장착/해제할 수 있습니다.
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;아이템 장착 시 Inventory에 해당 아이템이 어두워지며 E표시가 나타납니다.




2. 선택요구사항

   2-1. 아이템을 클릭하면 정보가 팝업에 나타납니다.


 <과제 관련 scripts>
- Scripts_UI_StartSceneUI
- Scripts_UI_InventoryBtn


---
## ⭐ 기능 

1. Player

   1-1. Player 이동
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;WASD를 사용해 Player를 움직일 수 있습니다. Player는 마우스 방향에 따라 좌우 반전됩니다.


   1-2. 카메라가 Player를 따라가기
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;카메라는 Player의 움직임을 따라갑니다.


   1-3. 캐릭터 애니메이션

   1-4. Player 공격
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Mouse Left Click 으로 Player가 화살을 발사해 적에게 데미지를 입힙니다.


2. Level
 
   2-1. 방 만들기
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;콜라이더를 이용해 벽을 넘어가지 못합니다.

   2-2. NPC
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;맵에 NPC를 배치했습니다.

   2-3. Enemy
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;근거리 1종, 원거리 1종의 적이 5가지 스폰포인트에서 랜덤하게 출현합니다.


3. UI
   
   3-1. 시간 표시
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;UI 좌측 상단에 현재 시간을 표시합니다.

   3-2. Ingame UI

   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;UI 상단에 현재 wave (단계) 와 Player의 HP를 표시합니다.

   3-3. GameOver 패널
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Player의 HP가 0이 되면 [GAME OVER] 패널이 등장합니다.


