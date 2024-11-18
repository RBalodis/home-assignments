import React, { useState } from 'react';

import { MobileContainer } from '../../components/global-header/mobile/MobileContainer';
import { MobileMenuList } from '../../components/global-header/mobile/MobileMenuList';
import { MobileMenuItem } from '../../components/global-header/mobile/MobileMenuItem';
import {
    MobileMenuAction,
    MobileMenuActionAs,
} from '../../components/global-header/mobile/MobileMenuAction';
import { AccordionMenu } from '../../components/accordion-menu/AccordionMenu';
import { AccordionMenuList } from '../../components/accordion-menu/AccordionMenuList';
import { AccordionMenuItem } from '../../components/accordion-menu/AccordionMenuItem';
import {
    AccordionMenuAction,
    AccordionMenuActionAs,
} from '../../components/accordion-menu/AccordionMenuAction';

export const MobilePrimaryNav = () => {
    const [menuIsOpen, setMenuIsOpen] = useState(false);
    const menuButtonClicked = () => {
        setMenuIsOpen(!menuIsOpen);
    };

    return (
        <MobileContainer>
            <MobileMenuList>
                <MobileMenuItem className={'logo-holder'}>
                    <MobileMenuAction
                        to={'/'}
                        as={MobileMenuActionAs.NAV_LINK}
                        className={'logo small'}
                    >
                        <span className={'if axe sr-only'}>Home</span>
                    </MobileMenuAction>
                </MobileMenuItem>

                <MobileMenuItem
                    className={'mobile-menu-holder'}
                    isOpen={menuIsOpen}
                >
                    <MobileMenuAction
                        onClick={menuButtonClicked}
                        as={MobileMenuActionAs.BUTTON}
                        className={'button mobile-menu'}
                    >
                        Menu
                    </MobileMenuAction>

                    <AccordionMenu isOpen={menuIsOpen}>
                        <AccordionMenuList>
                            <AccordionMenuItem>
                                <AccordionMenuAction
                                    onClick={() => setMenuIsOpen(false)}
                                    to={'/policies'}
                                    as={AccordionMenuActionAs.NAV_LINK}
                                >
                                    Policies
                                </AccordionMenuAction>
                            </AccordionMenuItem>
                        </AccordionMenuList>
                    </AccordionMenu>
                </MobileMenuItem>
            </MobileMenuList>
        </MobileContainer>
    );
};
