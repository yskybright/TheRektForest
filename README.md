유건희_심화주차 개인 프로젝트

# The Rekt Forest
Personal Assignment for Unity Bootcamp 2023.

   🔹장르 ) 2D TopDown Shooting, Defence


   🔹게임 소개 ) 

<img src="https://github.com/yskybright/TheRektForest/assets/148968024/a210e889-246c-4025-baa4-8ba5255e89fd.png" width="500" height="300"/>

---

   🔹개인과제 시연영상 ) https://youtu.be/yN79vQnKJQw

<img src="https://github.com/yskybright/TheRektForest/assets/148968024/ea03b0cc-81fd-4ad2-aa45-40920c461ba8.png" width="400" height="240"/>
<img src="https://github.com/yskybright/TheRektForest/assets/148968024/7ab6edbb-ffac-4882-832c-264d6a3ee02e.png" width="400" height="240"/>
<img src="https://github.com/yskybright/ZepDungeon/assets/148968024/9d5a03b4-b575-46a9-b846-f470db34e69e.png" width="400" height="240"/>
<img src="https://github.com/yskybright/TheRektForest/assets/148968024/dbe3785d-4760-4b70-ab60-a6a404001f35.png" width="400" height="240"/>



---
## ⭐ 필수 요구 사항

### 1. 인트로 씬

   1-1. 게임 소개 버튼
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;버튼을 누르면 간략한 게임 스토리가 나타납니다.
   
   1-2. 시작 버튼
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;버튼을 누르면 Lobby로 이동합니다.
   

---
## ⭐ 기능 

### 1. Player

   1-1. Player 이동
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;WASD를 사용해 Player를 움직일 수 있습니다. Player는 마우스 방향에 따라 좌우 반전됩니다.

   1-2. 카메라가 Player를 따라가기
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;카메라는 Player의 움직임을 따라갑니다.

   1-3. 애니메이션
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;바라보는 방향에 따라 sprite가 변화하며, 달릴 때 동작 애니메이션과 지면에 먼지 효과를 추가했습니다.

   1-4. Player 공격
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Mouse Left Click 으로 Player가 화살을 발사해 적에게 데미지를 입힙니다.

   1-5. Player 사망
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Player의 HP가 0이 되면 Player가 사라지며 게임이 종료됩니다.


### 2. Level
 
   2-1. 방 만들기
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;콜라이더를 이용해 벽을 넘어가지 못합니다.

   2-2. NPC
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;맵에 NPC를 배치했습니다.

   2-3. Enemy
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;근거리 1종, 원거리 1종의 적이 11가지 스폰포인트에서 랜덤하게 출현합니다.

   2-4. Wave 증가에 따른 난이도 상승
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Wave가 2,3,5의 배수가 될 때마다 적이 강화됩니다.


### 3. UI
   
   3-1. Lobby UI
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;캐릭터 명, 레벨, 골드, Status 버튼, Inventory 버튼, 던전 입장 버튼, 시계

   3-1-1. Status
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Status 버튼을 누르면 다른 UI 버튼은 사라지며 Status 창이 나타납니다.
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;팝업 우측 상단의 X를 누르면 Status 창이 사라지며 UI 버튼이 나타납니다.

   3-1-2. Inventory 
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Inventory 버튼을 누르면 다른 UI 버튼은 사라지며 Inventory 창이 나타납니다.
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;팝업 우측 상단의 X를 누르면 Inventory 창이 사라지며 UI 버튼이 나타납니다.
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;아이템을 클릭하면 장착 여부에 따라 아이템 팝업이 나타나며 아이템을 장착/해제할 수 있습니다.
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;아이템 장착 시 Inventory에 해당 아이템이 어두워지며 E표시가 나타납니다.
   
   3-2. InGame UI

   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;UI 상단에 현재 wave (단계) 와 Player의 HP를 표시합니다.

   3-3. GameOver 패널
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Player의 HP가 0이 되면 [GAME OVER] 패널이 등장합니다.

   3-3-1. Retry Button

   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Retry를 누르면 다시 Wave 1부터 게임을 플레이할 수 있습니다.

   3-3-2. Exit Button

   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Exit를 누르면 Lobby로 이동합니다.


### 4. Items
   
   4-1. 인게임 소비 아이템
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Player를 도와주는 3가지 아이템이 GameScene에 랜덤하게 드랍됩니다.
   
   4-1-1. Red Potion
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Player의 체력을 5 회복시킵니다.

   4-1-2. Blue Potion
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Player의 투사체를 강화합니다.

   4-1-3. Green Potion
   
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Player의 최대 체력을 5 증가시키며 일시적으로 속도를 증가시킵니다.

