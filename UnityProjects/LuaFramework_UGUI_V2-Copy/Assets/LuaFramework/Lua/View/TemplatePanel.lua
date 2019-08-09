local transform
local gameObject

TemplatePanel = {}

-- this指向table对象
local this = TemplatePanel

-- Panel的Awake方法，会在Ctrl里加载
function TemplatePanel.Awake(obj)
    gameObject = obj
    transform = obj.transform

    this.InitPanel()
end

-- 初始化面板
function TemplatePanel.InitPanel()
    -- btn按钮初始化
    -- this.btnClose = transform:FindChild("Button").gameObject;
    -- this.btnOpen = transform:Find("Open").gameObject;
	-- this.gridParent = transform:Find('ScrollView/Grid');
    
    this.btnObj = transform:Find('Panel/LoginBtn').gameObject
    
    -- Image初始化
    this.image = transform:Find('Panel/BG').gameObject:GetComponent('Image')
end