
--------------------------------
-- @module ProtocolAnalytics
-- @extend PluginProtocol
-- @parent_module plugin

--------------------------------
-- @function [parent=#ProtocolAnalytics] logTimedEventBegin 
-- @param self
-- @param #char char
        
--------------------------------
-- @function [parent=#ProtocolAnalytics] logError 
-- @param self
-- @param #char char
-- @param #char char
        
--------------------------------
-- @function [parent=#ProtocolAnalytics] setCaptureUncaughtException 
-- @param self
-- @param #bool bool
        
--------------------------------
-- @function [parent=#ProtocolAnalytics] setSessionContinueMillis 
-- @param self
-- @param #long long
        
--------------------------------
-- @function [parent=#ProtocolAnalytics] logEvent 
-- @param self
-- @param #char char
-- @param #map_table map
        
--------------------------------
-- @function [parent=#ProtocolAnalytics] startSession 
-- @param self
-- @param #char char
        
--------------------------------
-- @function [parent=#ProtocolAnalytics] stopSession 
-- @param self
        
--------------------------------
-- @function [parent=#ProtocolAnalytics] logTimedEventEnd 
-- @param self
-- @param #char char
        
return nil
