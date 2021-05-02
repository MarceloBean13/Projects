/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_lstadd_back.c                                   :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/03/01 11:36:52 by mfeijao           #+#    #+#             */
/*   Updated: 2021/03/01 11:37:32 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

void	ft_lstadd_back(t_list **lst, t_list *new)
{
	t_list *temp;

	temp = *lst;
	if (!temp)
		*lst = new;
	else
	{
		while ((temp)->next)
			temp = temp->next;
		temp->next = new;
	}
}
