import React from 'react';

import { DesktopMenuList } from '../../components/global-header/desktop/DesktopMenuList';
import { DesktopMenuItem } from '../../components/global-header/desktop/DesktopMenuItem';
import {
    DesktopMenuAction,
    DesktopMenuActionAs,
} from '../../components/global-header/desktop/DesktopMenuAction';
import { DesktopContainer } from '../../components/global-header/desktop/DesktopContainer';

export const DesktopSecondaryNav = () => {
    return (
        <DesktopContainer>
            <DesktopMenuList>
                <DesktopMenuItem className={'logo-holder'}>
                    <DesktopMenuAction
                        as={DesktopMenuActionAs.NAV_LINK}
                        to={'/'}
                        className={'logo small'}
                    >
                        <span className="if axe sr-only">Home</span>
                    </DesktopMenuAction>
                </DesktopMenuItem>

                <DesktopMenuItem>
                    <DesktopMenuAction
                        as={DesktopMenuActionAs.NAV_LINK}
                        to={'/policies'}
                    >
                        Policies
                    </DesktopMenuAction>
                </DesktopMenuItem>
            </DesktopMenuList>
        </DesktopContainer>
    );
};
