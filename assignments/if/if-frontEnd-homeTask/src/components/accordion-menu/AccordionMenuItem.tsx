import React, { HTMLAttributes, ReactNode } from 'react';
import classnames from 'classnames';

export interface AccordionMenuItemProps {
    children: ReactNode;
    className?: HTMLAttributes<HTMLLIElement>['className'];
    isParent?: boolean;
    isActive?: boolean;
}

export const AccordionMenuItem = ({
    children,
    className,
    isParent,
    isActive,
}: AccordionMenuItemProps) => {
    return (
        <li
            className={classnames('if', className, {
                'is-parent': isParent,
                'is-active': isActive,
            })}
        >
            {children}
        </li>
    );
};
